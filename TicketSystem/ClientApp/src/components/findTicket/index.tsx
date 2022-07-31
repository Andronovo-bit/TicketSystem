import type { DatePickerProps } from "antd";
import { DatePicker } from "antd";
import {
  EnvironmentOutlined,
  RightCircleOutlined,
  RetweetOutlined,
  CalendarOutlined,
} from "@ant-design/icons";
import { Select, Button } from "antd";
import background from "../../assets/spring-background-2020.png";
import { useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import { GetLocations } from "../../services/GetLocations";
import { GetTransferPoints } from "../../services/GetTransferPoints";
import { KaraNokta } from "../../models/KaraNokta";
import _ from "lodash";
const { Option } = Select;

const FindTicket = () => {
  const navigate = useNavigate();
  const [from, setFrom] = useState("");
  const [to, setTo] = useState("");
  const [date, setDate] = useState("");   

  const [trasferPoints, setTransferPoints] = useState([] as KaraNokta[]);

  const handleChange = (value:string) => {
    console.log(`selected ${value}`);
    setFrom(value);
  };

  const handleStateChange = (value: string) => {
    console.log(`selected ${value}`);
    setTo(value);
  };

  const onChange: DatePickerProps["onChange"] = (
    date: any,
    dateString: string
  ) => {
    console.log(date, dateString);
    setDate(dateString);
  };

  const addDays = (date: any, days: number) => {
    var result = new Date(date);
    result.setDate(result.getDate() + days);
    return result;
  };

  const goDetail = () => {
    GetLocations({
      firmaNo: "0",
      kalkisNoktaID: from,
      varisNoktaID: to,
      tarih: date,
      araNoktaGelsin: 1,
      islemTipi: "0",
      yolcuSayisi: 1,
      ip: "127.0.0.1",
    })
      .then((res) => {
        console.log(res);
        localStorage.setItem("seferler", JSON.stringify(res));
        navigate('/seferler')

      })
      .catch((err) => {
        console.log(err);
        alert("Aradğınız sefer bulunamadı.");
      });
  };

  const changeLocation = () => {};

//   useEffect(() => {
//     GetTransferPoints()
//       .then((data: KaraNokta[]) => {
//         setTransferPoints(data);

//       })
//       .catch((err) => {
//         console.log(err);
//       });
//   }, []);

  useEffect(() => {
    const loadData = async () => {
      const data = await GetTransferPoints().catch((err) => {
        console.log(err);
        alert("Hata oluştu");
        });
      setTransferPoints(_.orderBy(data.karaNokta, ["merkezMi","id"] , ["desc","asc"]));
    };
    loadData();
      
  }, [this]);

    console.log(trasferPoints);

  return (
    <>
      <div className="relative">
        <img src={background} alt="background" />
      </div>
      <div className="w-[30%] m-auto bg-white rounded-lg p-5 absolute top-14 left-[35%]">
        <div>
          <div className="flex items-center border-b-2 border-[#ededed] p-2">
            <EnvironmentOutlined />
            <div className="input-area flex flex-col pl-2">
              <span className="text-[#9d9d9c] font-semibold pl-[11px]">
                Nereden
              </span>
              <Select
                style={{ width: 350 }}
                onChange={handleChange}
                autoClearSearchValue={true}
                autoFocus={true}
                showSearch={true}
                onSelect={(value:any) => {
                    console.log(value);
                    }
                
                }
              >
                {
                trasferPoints && trasferPoints.length > 0
                  ? trasferPoints.map((item: KaraNokta) => {
                    console.log(item);
                      return (
                        <Option key={item.id} value={item.id}>
                          {item.ad}
                        </Option>
                      );
                    })
                  : null}
              </Select>
            </div>
          </div>
          <div className="flex items-center border-b-2 border-[#ededed] p-2">
            <EnvironmentOutlined />
            <div className="input-area flex flex-col pl-2">
              <span className="text-[#9d9d9c] font-semibold pl-[11px]">
                Nereye
              </span>
              <Select
                style={{ width: 350 }}
                onChange={handleStateChange}
                className="select-box"
                autoClearSearchValue={true}
                autoFocus={true}
                showSearch={true}

              >
                 {
                trasferPoints && trasferPoints.length > 0
                  ? trasferPoints.map((item: KaraNokta) => {
                      return (
                        <Option key={item.id} value={item.id}>
                          {item.ad}
                        </Option>
                      );
                    })
                  : null}
              </Select>
            </div>
          </div>
          <div className="changechooise absolute top-[70px] right-[110px]">
            <Button
              className="flex items-center justify-center w-[30px] h-[30px] rounded-full p-[5px] border-black"
              onClick={() => {
                setFrom(to);
                setTo(from);
              }}
            >
              <RetweetOutlined onClick={changeLocation} />
            </Button>
          </div>
          <div className="flex items-center p-2">
            <CalendarOutlined />
            <div className="input-area flex flex-col pl-2">
              <span className="text-[#9d9d9c] font-semibold pl-[11px]">
                Gidiş Tarihi
              </span>

              <DatePicker onChange={onChange} />
            </div>
          </div>
          <div className="p-2">
            <Button
              onClick={goDetail}
              className="find-ticket bg-[#e38037] p-5 rounded-lg flex items-center justify-center w-full"
            >
              <span className="pr-2 font-bold text-white">
                OTOBÜS BİLETİ BUL
              </span>
              <RightCircleOutlined style={{ color: "#fff" }} />
            </Button>
          </div>
        </div>
      </div>
    </>
  );

 
};

export default FindTicket;
