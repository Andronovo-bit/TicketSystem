import {
  Layout,
  Col,
  Collapse,
  Row,
  Button,
  Modal,
  Menu,
  Dropdown,
  Space,
  PageHeader,
  Select,
} from "antd";
import firmalogo from "../../assets/metro.png";
import {
  ClockCircleOutlined,
  UserOutlined,
  WifiOutlined,
  ApiOutlined,
  DownCircleOutlined,
  DownOutlined,
} from "@ant-design/icons";
import ChooseSeats from "../chooseSeats";
import { useEffect, useState } from "react";
import { Sefer } from "../../models/Sefer";
import Icon from "antd/lib/icon";
import { GetRoutes } from "../../services/GetRoutes";
import { GetRoute } from "../../models/GetRoute";
import { RouteDetail } from "../../models/RouteDetail";
import { GetBus } from "../../models/GetBus";
import { GetBusDetail } from "../../services/GetBusDetail";
import _ from "lodash";

const { Header } = Layout;
const { Panel } = Collapse;

const ExpeditionInformation = () => {
  var seferlerData = JSON.parse(localStorage.getItem("seferler") || "[]");

  if (seferlerData?.length == 0) {
    return (
      <Row className="flex mt-10 justify-around items-center bg-grey w-full border-b-[1px] border-[#dedede] ">
        <Col className="flex items-center flex-col" span={24}>
          <h1>
            {" "}
            Seçtiğiniz duraklar arasında otobüs seferi bulunamamaktadır.{" "}
          </h1>
        </Col>
      </Row>
    );
  }
  useEffect(() => {
    console.log(seferlerData);
  }, [seferlerData]);
  var seferler = seferlerData.table as Sefer[];

  const [modalShow, setShowModal] = useState(false);
  const [seferHatDetay, setseferHatDetay] = useState({} as RouteDetail[]);
  const [busDetail, setBusDetail] = useState({} as any);
  const [busSpecial, setBusSpecial] = useState({} as any);
  const [sortPrice, setSortPrice] = useState("asc");
  const [sortTime, setSortTime] = useState("asc");

  var activeSpecialty = [] as any;

  const clickLineDetailHandler = (sefer: Sefer) => {
    var getRoute = {
      firmaNo: sefer.firmaNo,
      hatNo: sefer.hatNo,
      kalkisNoktaID: sefer.kalkisNoktaID,
      varisNoktaID: sefer.varisNoktaID,
      seferTakipNo: sefer.seferTakipNo,
      bilgiIslemAdi: "GuzergahVerSaatli",
      tarih: new Date(sefer.tarih).toISOString().split("T")[0],
    } as GetRoute;

    GetRoutes(getRoute).then((res: any) => {
      if (res && res.table1) {
        setseferHatDetay(res.table1);
        setShowModal(true);
      }
    });

    var getBus = {
      firmaNo: sefer.firmaNo,
      kalkisNoktaID: sefer.kalkisNoktaID,
      varisNoktaID: sefer.varisNoktaID,
      tarih: new Date(sefer.tarih).toISOString().split("T")[0],
      saat: sefer.saat,
      hatNo: sefer.hatNo,
      islemTipi: 1,
      seferTakipNo: sefer.seferTakipNo,
      ip: "127.0.0.1",
    } as GetBus;
    GetBusDetail(getBus).then((res: any) => {
      if (res) {
        setBusDetail(res);

        res.sefer.oTipOzellik.split("").map((x: any, i: number) => {
          if (x == "1") {
            activeSpecialty.push(i);
          }
        });
        var filterSpec = res.oTipOzellik.filter(
          (t: any) =>
            activeSpecialty.find((p: any) => p == t.oTipOzellikId) != undefined
        );
        setBusSpecial(filterSpec);
      }
    });
  };

  const onChange = (key: any) => {
    console.log(key);
  };
  const addMinutes = (date: Date, minutes: number) => {
    return new Date(date.getTime() + minutes * 60000);
  };

  const orderSefer = (type: any, sortType: "asc" | "desc") => {
    if (type == "price") {
      if (sortType == "asc") {
        setSortPrice("desc");
        seferlerData.table = _.orderBy(
          seferler,
          ["biletFiyatiInternet"],
          ["desc"]
        );
      } else {
        setSortPrice("asc");
        seferlerData.table = _.orderBy(
          seferler,
          ["biletFiyatiInternet"],
          ["asc"]
        );
      }
    }
    if (type == "time") {
      if (sortType == "asc") {
        setSortTime("desc");
        seferlerData.table = _.orderBy(
          seferler,
          ["yerelInternetSaat"],
          ["desc"]
        );
      } else {
        setSortTime("asc");
        seferlerData.table = _.orderBy(
          seferler,
          ["yerelInternetSaat"],
          ["asc"]
        );
      }
    }

    localStorage.setItem("seferler", JSON.stringify(seferlerData));
  };

  const Desing = (data: Sefer): JSX.Element => {
    const priceFormat = Intl.NumberFormat("tr-TR", {
      style: "currency",
      currency: "TRY",
      minimumFractionDigits: 2,
    });
    const seyehatSuresi = new Date(data.seyahatSuresi);
    const kalkisSaati = new Date(data.yerelInternetSaat);

    return (
      <>
        <Row className="flex justify-around items-center bg-grey w-full border-b-[1px] border-[#dedede] ">
          <Col span={4}>
            <img
              width="75%"
              src={
                "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/partner/4071-sm.png"
              }
              alt="logo"
            />
          </Col>
          <Col span={4}>
            <div className="flex items-center flex-col">
              <div className="flex items-center">
                <ClockCircleOutlined />
                <span className="pl-2 font-bold">
                  {(kalkisSaati.getHours() > 9
                    ? kalkisSaati.getHours()
                    : "0" + kalkisSaati.getHours()) +
                    ":" +
                    (kalkisSaati.getMinutes() > 9
                      ? kalkisSaati.getMinutes()
                      : "0" + kalkisSaati.getMinutes())}
                </span>
              </div>

              <span>
                (
                {seyehatSuresi.getHours() +
                  " Saat " +
                  seyehatSuresi.getMinutes() +
                  " Dakika"}
                )*
              </span>
            </div>
          </Col>
          <Col span={8}>
            <div className="flex items-center flex-col">
              <div className="flex items-center">
                <UserOutlined />
                <span className="pl-2 flex font-bold">
                  {data.otobusKoltukYerlesimTipi}
                </span>
              </div>
              <span>{data.guzergah}</span>
            </div>
          </Col>
          <Col span={4}>
            <div className="flex justify-center">
              <span className="font-bold">
                {priceFormat.format(data.biletFiyatiInternet)}
              </span>
            </div>
          </Col>
          <Col span={4}>
            <div className="flex flex-col">
              <Button className="bg-[#e38037] text-white uppercase rounded-[8px] hover:bg-[#e38037] hover:text-white hover:border-[#e38037]">
                Koltuk Seç
              </Button>
              {data.seferBosKoltukSayisi < 10 ? (
                <span className="text-center text-[#8b8181] pt-[2px]">
                  Son {data.seferBosKoltukSayisi} Koltuk
                </span>
              ) : null}
            </div>
          </Col>
        </Row>
        <Row className="pt-[10px] items-center">
          <Col span={8}></Col>
          <Col span={8} className="flex justify-center">
            <div>
              <ul className="flex justify-center">
                <li className="p-1">
                  <WifiOutlined />
                </li>
                <li className="p-1">
                  <ApiOutlined />
                </li>
                <li className="p-1">
                  <ApiOutlined />
                </li>
                <li className="p-1">
                  <ApiOutlined />
                </li>
              </ul>
            </div>
          </Col>
          <Col span={8} className="flex justify-end">
            <div>
              <a className="flex items-center  hover:text-[#e38037]">
                <DownCircleOutlined />
                <span className="font-semibold pl-[4px]">İncele</span>
              </a>
            </div>
          </Col>
        </Row>
      </>
    );
  };

  const menu = (
    <Menu
      items={[
        {
          label: (
            <a onClick={() => orderSefer("time", sortTime as "asc" | "desc")}>
              Kalkış Saati
            </a>
          ),
          key: "0",
        },
        {
          label: (
            <a onClick={() => orderSefer("price", sortPrice as "asc" | "desc")}>
              Fiyat
            </a>
          ),
          key: "1",
        },
      ]}
    />
  );

  return (
    <>
      <section>
        <div className="ant-collapse ant-collapse-icon-position-start">
          <div className="ant-collapse-item">
            <div className="ant-collapse-header">
              <PageHeader>
                <Dropdown overlay={menu}>
                  <a onClick={(e) => e.preventDefault()}>
                    <Space>
                      Sırala
                      <DownOutlined />
                    </Space>
                  </a>
                </Dropdown>
                <>
                  <Select
                   className=""
                    mode="multiple"
                    allowClear
                    style={{ width: "25%" }}
                    placeholder="Sefer Tipi"
                    defaultValue={["a10", "c12"]}
                  ></Select>

                </>
              </PageHeader>
            </div>
          </div>
        </div>

        <Row>
          <Collapse defaultActiveKey={["1"]} onChange={onChange}>
            {seferler?.map((sefer, index) => (
              <Panel header={Desing(sefer)} key={index}>
                <div
                  onClick={() => clickLineDetailHandler(sefer)}
                  title="Esenler Otogarı - 00:00, Ataşehir Dudullu Terminali - 01:31, Gebze Otogarı - 02:31, İzmit Otogarı - 03:01, Adapazarı Otogarı - 03:31, Ankara (Aşti) Otogarı - 07:01"
                >
                  <strong>Güzergah:</strong> {sefer.kalkisNokta} Otogarı{" ("}
                  {new Date(sefer.yerelInternetSaat).getHours() > 9
                    ? new Date(sefer.yerelInternetSaat).getHours()
                    : "0" +
                      new Date(sefer.yerelInternetSaat).getHours() +
                      ":" +
                      (new Date(sefer.yerelInternetSaat).getMinutes() > 9
                        ? new Date(sefer.yerelInternetSaat).getMinutes()
                        : "0" + new Date(sefer.yerelInternetSaat).getMinutes())}
                  {") "}- {sefer.varisNokta} Otogarı {"10:00"}
                  <strong className="cursor-pointer">
                    Devamını görmek için tıklayın.
                  </strong>
                </div>
              </Panel>
            ))}
          </Collapse>
        </Row>
        <Modal
          title="Sefer Detayları"
          visible={modalShow}
          footer={null}
          onCancel={() => setShowModal(false)}
        >
          <h3 className="font-bold mt-[8px]">Uyarı</h3>
          <p className="leading-[16px]">
            Belirtilen süreler otobüs firması tarafından iletilmektedir. Kalkış
            ve varış saatleri tahmini olup saat değişiklikleri biletall.com
            sorumluluğunda değildir
          </p>
          <h3 className="font-bold mt-[8px]">Özellikler</h3>
          <Row>
            {busSpecial && busSpecial.length > 0
              ? busSpecial?.map((special: any, index: number) => (
                  <Col span={6}>
                    <div className="flex-col items-center m-4">
                      <img
                        width={50}
                        src={
                          "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/feature/" +
                          (special.oTipOzellikId + 3) +
                          ".svg"
                        }
                      />
                      <span className="pl-1 flex mt-1 ">
                        {special.oTipOzellikAciklama}
                      </span>
                    </div>
                  </Col>
                ))
              : null}
          </Row>

          <div>
            <h3 className="font-bold mt-[8px]">Güzergah</h3>

            <table className="w-full">
              <tbody>
                {seferHatDetay && seferHatDetay.length > 0
                  ? seferHatDetay?.map((sefer, index) => (
                      <tr
                        key={index}
                        className={index % 2 == 0 ? "bg-[#fafafa]" : ""}
                      >
                        <th className="text-left font-normal">
                          {new Date(sefer.varisTarihSaat).getHours() +
                            ":" +
                            (new Date(sefer.varisTarihSaat).getMinutes() < 10
                              ? "0" +
                                new Date(sefer.varisTarihSaat).getMinutes()
                              : new Date(sefer.varisTarihSaat).getMinutes())}
                        </th>
                        <td>{sefer.karaNoktaAd}</td>
                      </tr>
                    ))
                  : null}
              </tbody>
            </table>
          </div>
        </Modal>
      </section>
    </>
  );
};

export default ExpeditionInformation;
