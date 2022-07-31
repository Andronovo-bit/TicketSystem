import { Button, Col, Form, Input, Row } from "antd";
import {
  PrinterOutlined,
  ClockCircleOutlined,
  InfoOutlined,
  UserOutlined,
  CarOutlined,
  MessageOutlined,
  MailOutlined,
} from "@ant-design/icons";
import { useState } from "react";
import { QueryingPNR } from "../../models/QueryingPNR";
import { GetTicketInfoByPnrNo } from "../../services/GetTicketInfoByPnrNo";

const PassengerNameRecord = () => {
  const [form] = Form.useForm();

  const formatter = new Intl.DateTimeFormat("tr", { month: "long" });
  const formatterWeekDay = new Intl.DateTimeFormat("tr", { weekday: "long" });

  const [pnrDetails, setPnrDetails] = useState<any>();
  const [kalkisDate, setKalkisDate] = useState<any>();

  const onFinish = (values: QueryingPNR) => {
    GetTicketInfoByPnrNo(values)
      .then((data) => {
        setPnrDetails(data);
        setPnrPageShow(true);
        setKalkisDate(new Date(data.segment.kalkisTarih));
        console.log(data);
      })
      .catch((err) => {
        alert("Pnr sorgulanırken bir hata oluştu.");
        console.log(err);
      });
    console.log(values);
  };

  const [pnrPageShow, setPnrPageShow] = useState(false);

  const PNRPage = (): JSX.Element => {
    const print = () => {
      window.print();
    };
    return (
      <>
        <div id="PRNT" className="w-[70%] m-auto mt-5 mb-5">
          <Row className="pb-[10px] flex items-end">
            <Col span={6}>
              <div className="flex items-center">
                <UserOutlined />
                <p className="pl-2">Bilet Bilgileri</p>
              </div>
            </Col>
            <Col span={18} className="text-end">
              <Button className="ticket-button mr-[5px]">
                <div className="flex items-center">
                  <PrinterOutlined />{" "}
                  <a onClick={print} className="pl-2">
                    Yazdır
                  </a>
                </div>
              </Button>
              <Button className="ticket-button mr-[5px]">
                <div className="flex items-center">
                  <MessageOutlined /> <span className="pl-2">Sms Gönder</span>
                </div>
              </Button>
              <Button className="ticket-button">
                <div className="flex items-center">
                  <MailOutlined />
                  <span className="pl-2">E posta gönder</span>
                </div>
              </Button>
            </Col>
          </Row>
          <div>
            <div className="first-box mt-[2px]">
              <Row className="bg-[#ebebeb] p-[20px] flex items-center">
                <Col span={6}>
                  <span className="font-bold uppercase text-[22px]">
                    {(
                      pnrDetails.segment.kalkisKaraNokta +
                      " - " +
                      pnrDetails.segment.varisKaraNokta
                    ).toLocaleUpperCase()}
                  </span>
                </Col>
                <Col span={12}>
                  <span className="text-[15px]">
                    {kalkisDate?.getDate() +
                      " " +
                      formatter.format(kalkisDate) +
                      " " +
                      kalkisDate?.getFullYear() +
                      " " +
                      formatterWeekDay.format(kalkisDate) +
                      " " +
                      kalkisDate?.getHours() +
                      ":" +
                      kalkisDate?.getMinutes()}
                  </span>
                </Col>
                <Col span={6} className="text-end">
                  <div className="flex justify-end items-center">
                    <span>PNR:</span>
                    <span className="text-[20px] font-bold">
                      {pnrDetails.pnr.pnRno}
                    </span>
                  </div>
                </Col>
              </Row>
              <Row className="flex items-center px-4">
                <Col span={6}>
                  <img
                    width="75%"
                    src={
                      "https://s3.eu-central-1.amazonaws.com/static.obilet.com/images/partner/4071-sm.png"
                    }
                    alt="logo"
                  />
                </Col>
                <Col span={6} className="text-center">
                  <span className="font-bold uppercase text-[20px]">
                    {pnrDetails.segment.kalkisKaraNokta.toLocaleUpperCase()}
                  </span>
                </Col>
                <Col span={6} className="flex flex-col">
                  <div className="flex items-center justify-center">
                    <ClockCircleOutlined />
                    <span className="pl-2">
                      {pnrDetails.segment.yaklasikSeyahatSuresi} Saat
                    </span>
                  </div>
                </Col>
                <Col span={6} className="text-center">
                  <span className="font-bold uppercase text-[20px]">
                    {pnrDetails.segment.varisKaraNokta.toLocaleUpperCase()}
                  </span>
                </Col>
              </Row>
              <Row className="bg-[#ebebeb] p-[20px]">
                <Col className="pr-10">
                  <span className="flex">
                    <p className="font-bold">E posta</p> {pnrDetails.pnr.email}
                  </span>
                </Col>
                <Col>
                  <span className="flex">
                    <p className="font-bold">Telefon:</p>
                    {pnrDetails.pnr.tel}
                  </span>
                </Col>
              </Row>
            </div>

            <div className="flex mt-5 items-center">
              <InfoOutlined />
              <p>
                Otobüs tipi, güzergah ve seyahat süresi operasyonel
                zorunluluklardan dolayı değişebilir
              </p>
            </div>
            <div className="flex items-center">
              <InfoOutlined />
              <p className="uppercase text-red-700">
                Sayın yolcularımız, ikili koltuklar aileler içindir. Aile
                olmadığınız halde bu koltukları satın almanız durumunda yasal
                sorumluluk size aittir.
              </p>
            </div>
            <div className="text-end mt-5">
              <span className="text-[30px] font-bold">
                {pnrDetails.tahsilat ? ( "Toplam Ücret: " + pnrDetails?.tahsilat.tutar + " TL") : "Rezervasyon işlemidir."}
               
              </span>
            </div>
          </div>

          <div className="my-10">
            <div className="flex items-center">
              <UserOutlined />
              <span className="pl-[4px]">Yolcu Bilgileri</span>
            </div>

            <table className="w-full pass-information border-[#243c5a]">
              <tbody>
                <tr className="bg-[#ebebeb] table-inform">
                  <th className="t-inform">Yolcu Adı</th>
                  <th className="t-inform">Durum</th>
                  <th className="t-inform">Koltuk</th>
                  <th className="t-inform">E Bilet No</th>
                  <th className="t-inform">Servis İsteği</th>
                  <th className="t-inform">Bilet İşlemlerim</th>
                </tr>

                {pnrDetails.yolcu.map((yolcu: any, index: number) => (
                  <>
                    <tr className="passanger-inform">
                      <td className="font-bold uppercase">{yolcu.kullanici}</td>
                      <td className="font-bold">{yolcu.islemTipi}</td>
                      <td className="font-bold">{yolcu.koltukNo}</td>
                      <td className="font-bold">{yolcu.eBiletNo}</td>
                      <td className="font-bold">{yolcu.binisServis}</td>
                      <td className="font-bold">{yolcu.acente}</td>
                    </tr>
                  </>
                ))}
              </tbody>
            </table>
          </div>

          <div className="mb-5">
            <div className="flex items-center">
              <CarOutlined />
              <span className="pl-[4px]">Sefer Bilgileri</span>
            </div>

            <table className="w-full transform-information border-[#eeecec] mb-5">
              <tbody>
                <tr className="bg-[#ebebeb] table-inform">
                  <th className="t-inform">Sefer Süresi</th>
                  <th className="t-inform">Sefer Tipi</th>
                  <th className="t-inform">Sefer No</th>
                  <th className="t-inform">Cinsiyet</th>
                  <th className="t-inform">Peron</th>
                </tr>

                <tr className="passanger-inform">
                  <td className="font-bold uppercase">
                    {pnrDetails.segment.yaklasikSeyahatSuresi} Saat
                  </td>
                  <td className="font-bold">{pnrDetails.segment.seferTip} </td>
                  <td className="font-bold">
                    {pnrDetails.segment.seferTakipNo}{" "}
                  </td>
                  <td className="font-bold">Erkek </td>
                  <td className="font-bold">{pnrDetails.segment.peronNo} </td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </>
    );
  };

  const PNRForm = () => {
    return (
      <>
        <Form form={form} onFinish={onFinish}>
          <Form.Item name="pnrNo">
            <Input placeholder="PNR" />
          </Form.Item>

          <Form.Item name="pnrAramaParametre">
            <Input placeholder="TC/Soyisim" />
          </Form.Item>

          <Form.Item
            style={{
              display: "flex",
              justifyContent: "center",
            }}
          >
            <Button className="secondary" htmlType="submit">
              Sorgula
            </Button>
          </Form.Item>
        </Form>
      </>
    );
  };

  return (
    <>
      {" "}
      <div className="flex flex-col m-auto mt-5 mb-5 justify-center">
        <div className="flex flex-col items-center justify-center">
          <div className="flex items-center border-dashed border-2 justify-center">
            <PNRForm></PNRForm>
          </div>
        </div>
      </div>
      {pnrPageShow && pnrDetails ? <PNRPage /> : null}
    </>
  );
};

export default PassengerNameRecord;
