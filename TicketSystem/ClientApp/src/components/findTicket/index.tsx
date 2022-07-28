import type { DatePickerProps } from 'antd';
import { DatePicker } from 'antd';
import { EnvironmentOutlined, RightCircleOutlined, RetweetOutlined, CalendarOutlined } from '@ant-design/icons';
import { Select, Button } from 'antd';
import background from "../../assets/spring-background-2020.png"
import { useNavigate } from 'react-router-dom';
import { useState } from 'react';
const { Option } = Select;

const FindTicket = () => {

    const navigate = useNavigate();
    const [from, setFrom] = useState("lucy")
    const [to, setTo] = useState("Yiminghe")


    const handleChange = (value: string) => {
        console.log(`selected ${value}`);
        setFrom(value)
    };

    const handleStateChange = (value: string) => {
        console.log(`selected ${value}`);
        setTo(value)
    };

    const onChange: DatePickerProps['onChange'] = (date:any, dateString:string) => {
        console.log(date, dateString);
    };

    const goDetail = () => {
        navigate('/seferler')
    }

    const changeLocation = () => {

    }

    return (
        <>
            <div className='relative'>
                <img src={background} alt="background" />
            </div>
            <div className='w-[30%] m-auto bg-white rounded-lg p-5 absolute top-14 left-[35%]'>
                <div>
                    <div className='flex items-center border-b-2 border-[#ededed] p-2'>
                        <EnvironmentOutlined />
                        <div className='input-area flex flex-col pl-2'>
                            <span className='text-[#9d9d9c] font-semibold pl-[11px]'>Nereden</span>
                            <Select defaultValue="lucy" style={{ width: 400 }} value={from} onChange={handleChange}>
                                <Option value="jack">Jack</Option>
                                <Option value="lucy">Lucy</Option>
                                <Option value="Yiminghe">yiminghe</Option>
                            </Select>
                        </div>

                    </div>
                    <div className='flex items-center border-b-2 border-[#ededed] p-2'>
                        <EnvironmentOutlined />
                        <div className='input-area flex flex-col pl-2'>
                            <span className='text-[#9d9d9c] font-semibold pl-[11px]'>Nereye</span>
                            <Select defaultValue="Yiminghe" style={{ width: 400 }} value={to} onChange={handleStateChange} className='select-box'>
                                <Option value="jack">Jack</Option>
                                <Option value="lucy">Lucy</Option>
                                <Option value="Yiminghe">Yiminghe</Option>
                            </Select>
                        </div>
                    </div>
                    <div className='changechooise absolute top-[70px] right-[110px]'>
                        <Button className='flex items-center justify-center w-[30px] h-[30px] rounded-full p-[5px] border-black' onClick={() => {
                            setFrom(to);
                            setTo(from);
                        }}>
                            <RetweetOutlined onClick={changeLocation} />
                        </Button>
                    </div>
                    <div className='flex items-center p-2'>
                        <CalendarOutlined />
                        <div className='input-area flex flex-col pl-2'>
                            <span className='text-[#9d9d9c] font-semibold pl-[11px]'>Gidiş Tarihi</span>

                            <DatePicker onChange={onChange} />
                        </div>
                    </div>
                    <div className='p-2'>
                        <Button onClick={goDetail} className='find-ticket bg-[#e38037] p-5 rounded-lg flex items-center justify-center w-full'>
                            <span className='pr-2 font-bold text-white'>
                                OTOBÜS BİLETİ BUL
                            </span>
                            <RightCircleOutlined style={{ color: '#fff' }} />
                        </Button>
                    </div>
                </div>
            </div>
        </>
    )
}

export default FindTicket