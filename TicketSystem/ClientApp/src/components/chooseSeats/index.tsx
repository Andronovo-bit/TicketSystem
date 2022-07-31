import {
  Button,
  Form,
  Input,
  InputNumber,
  Select,
  Tooltip,
} from "antd";
import {
  InfoCircleOutlined,
  UserOutlined,
} from "@ant-design/icons";
import { Sefer } from "../../models/Sefer";
import { BookRezervation, WebYolcu } from "../../models/BookRezervation";
import { MakeRezervation } from "../../services/MakeRezervation";
//import { myFunction } from 'react-seat-picker';
const { Option } = Select;

const ChooseSeats = (props: Sefer) => {

  const [form] = Form.useForm();

  const onFinish = (values: any) => {
    var webyolcu = {
      Email: values.email
    } as WebYolcu
    var rezervationModel = {
      firmaNo: props.firmaNo,
      firmaAciklama: props.firmaSeferAciklamasi.substring(0, 19),
      kalkisNoktaID: props.kalkisNoktaID,
      varisNoktaID: props.varisNoktaID,
      tarih: new Date(props.tarih).toISOString().split("T")[0],
      saat: props.saat,
      hatNo: props.hatNo,
      seferNo: props.seferTakipNo,
      kalkisTerminalAdiSaatleri: props.kalkisTerminalAdiSaatleri,
      koltukNo1: values.seatNumber,
      adi1: values.name,
      soyadi1: values.surname,
      tcKimlikNo1: values.tcno,
      cinsiyet: values.gender,
      telefonNo: values.phone,
      yolcuSayisi: 1,
      hatirlaticiNot: "",
      servisYeriKalkis1: "",
      WebYolcu: webyolcu
    } as BookRezervation;

    console.log("Success:", rezervationModel);

    MakeRezervation(rezervationModel)
      .then((data) => {
        console.log(data);
      })
      .catch((err) => {
        console.log(err);
      });
  };

  const onFinishFailed = (errorInfo: any) => {
    console.log("Failed:", errorInfo);
  };

  return (
    <>
      <Form
        name="basic"
        labelCol={{ span: 8 }}
        wrapperCol={{ span: 16 }}
        initialValues={{ remember: true }}
        onFinish={onFinish}
        onFinishFailed={onFinishFailed}
        autoComplete="on"
        form={form}
      >
        <Form.Item
          label="İsim"
          name="name"
          rules={[{ required: true, message: "Please input your name!" }]}
        >
          <Input
            placeholder="İsminizi giriniz"
            prefix={<UserOutlined className="site-form-item-icon" />}
            suffix={
              <Tooltip title="Extra information">
                <InfoCircleOutlined style={{ color: "rgba(0,0,0,.45)" }} />
              </Tooltip>
            }
          />
        </Form.Item>

        <Form.Item
          label="Soyisim"
          name="surname"
          rules={[{ required: true, message: "Please input your Surname!" }]}
        >
          <Input
            placeholder="Soyisminizi giriniz"
            prefix={<UserOutlined className="site-form-item-icon" />}
            suffix={
              <Tooltip title="Extra information">
                <InfoCircleOutlined style={{ color: "rgba(0,0,0,.45)" }} />
              </Tooltip>
            }
          />
        </Form.Item>

        <Form.Item
          label="Tc Kimlik No"
          name="tcno"
          rules={[{ required: false, message: "Please input your Tc No!" }]}
        >
          <Input />
        </Form.Item>

        <Form.Item
          label="Telefon"
          name="phone"
          rules={[{ required: false, message: "Please input your Tc No!" }]}
        >
          <Input />
        </Form.Item>

        <Form.Item
         label="E-Mail"
         name="email"
         rules={[{ required: true, message: "Please input your Email!" }]}>
          <Input autoComplete="true" placeholder="Mail adresinizi giriniz">
          </Input>
        </Form.Item>

        <Form.Item
          label="Koltuk No"
          name="seatNumber"
          rules={[{ required: true, message: "Please input your Seat Number" }]}
        >
          <InputNumber />
        </Form.Item>

        <Form.Item
          name="gender"
          label="Cinsiyet"
          rules={[{ required: true, message: "Please input your Gender!" }]}
        >
          <Select placeholder="Cinsiyet Seçiniz" allowClear>
            <Option value={2}>Kadın</Option>
            <Option value={1}>Erkek</Option>
          </Select>
        </Form.Item>

        <Form.Item wrapperCol={{ offset: 8, span: 16 }}>
          <Button type="dashed" htmlType="submit">
            Rezervasyon Yap
          </Button>
        </Form.Item>
      </Form>
    </>
  );
};

export default ChooseSeats;
