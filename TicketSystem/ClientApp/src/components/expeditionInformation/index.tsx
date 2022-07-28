import { Layout, Col, Collapse, Row, Button, Modal } from 'antd';
import firmalogo from "../../assets/metro.png"
import { ClockCircleOutlined, UserOutlined, WifiOutlined, ApiOutlined, DownCircleOutlined } from '@ant-design/icons';
import ChooseSeats from '../chooseSeats';
import { useState } from 'react';

const { Header } = Layout;
const { Panel } = Collapse;


const ExpeditionInformation = () => {

    const [modalShow, setShowModal] = useState(false)

    const onChange = (key: any) => {
        console.log(key);
    };

    const Design = (
        <>
            <Row className='flex justify-around items-center bg-grey w-full border-b-[1px] border-[#dedede] '>
                <Col span={4} >
                    <img src={firmalogo} alt="logo" />
                </Col>
                <Col span={4}>
                    <div className='flex items-center flex-col'>
                        <div className='flex items-center'>
                            <ClockCircleOutlined /> <span className='pl-2 font-bold'>00:05</span>

                        </div>

                        <span>(6 Saat 20 Dakika)*</span>
                    </div>
                </Col>
                <Col span={8}>
                    <div className='flex items-center flex-col'>
                        <div className='flex items-center'>
                            <UserOutlined /><span className='pl-2 flex font-bold'>2+1</span>
                        </div>
                        <span>Alibeyköy Otogarı - Ankara (Aşti) Otogarı</span>

                    </div>
                </Col>
                <Col span={4}>
                    <div className='flex justify-center'>
                        <span className='font-bold'>300 TL</span>
                    </div>
                </Col>
                <Col span={4}>
                    <div className='flex flex-col'>
                        <Button className='bg-[#e38037] text-white uppercase rounded-[8px] hover:bg-[#e38037] hover:text-white hover:border-[#e38037]'>
                            Koltuk Seç
                        </Button>
                        <span className='text-center text-[#8b8181] pt-[2px]'>Son 8 Koltuk</span>

                    </div>
                </Col>
            </Row>
            <Row className='pt-[10px] items-center'>
                <Col span={8}>
                </Col>
                <Col span={8} className='flex justify-center'>
                    <div>
                        <ul className='flex justify-center'>
                            <li className='p-1'>
                                <WifiOutlined />
                            </li>
                            <li className='p-1'>
                                <ApiOutlined />
                            </li>
                            <li className='p-1'>
                                <ApiOutlined />
                            </li>
                            <li className='p-1'>
                                <ApiOutlined />
                            </li>
                        </ul>
                    </div>
                </Col>
                <Col span={8} className='flex justify-end'>
                    <div>
                        <a className='flex items-center  hover:text-[#e38037]'>
                            <DownCircleOutlined />
                            <span className='font-semibold pl-[4px]'>İncele</span>
                        </a>
                    </div>
                </Col>
            </Row>
        </>
    )

    return (
        <>
            <Row>
                <Collapse defaultActiveKey={['1']} onChange={onChange}>
                    <Panel header={Design} key="1">

                        <div onClick={() => setShowModal(true)} title="Esenler Otogarı - 00:00, Ataşehir Dudullu Terminali - 01:31, Gebze Otogarı - 02:31, İzmit Otogarı - 03:01, Adapazarı Otogarı - 03:31, Ankara (Aşti) Otogarı - 07:01">
                            <strong>Güzergah:</strong> Esenler Otogarı (00:00) - Ankara (Aşti) Otogarı (07:01) <strong className='cursor-pointer'>Devamını görmek için tıklayın.</strong>
                        </div>
                    </Panel>
                    <Panel header={Design} key="2">
                        <div onClick={() => setShowModal(true)} title="Esenler Otogarı - 00:00, Ataşehir Dudullu Terminali - 01:31, Gebze Otogarı - 02:31, İzmit Otogarı - 03:01, Adapazarı Otogarı - 03:31, Ankara (Aşti) Otogarı - 07:01">
                            <strong>Güzergah:</strong> Esenler Otogarı (00:00) - Ankara (Aşti) Otogarı (07:01) <strong className='cursor-pointer'>Devamını görmek için tıklayın.</strong>
                        </div>
                    </Panel>
                    <Panel header={Design} key="3">
                        <div onClick={() => setShowModal(true)} title="Esenler Otogarı - 00:00, Ataşehir Dudullu Terminali - 01:31, Gebze Otogarı - 02:31, İzmit Otogarı - 03:01, Adapazarı Otogarı - 03:31, Ankara (Aşti) Otogarı - 07:01">
                            <strong>Güzergah:</strong> Esenler Otogarı (00:00) - Ankara (Aşti) Otogarı (07:01) <strong className='cursor-pointer'>Devamını görmek için tıklayın.</strong>
                        </div>
                    </Panel>
                </Collapse>

            </Row>
            <Modal title="Sefer Detayları" visible={modalShow} footer={null} onCancel={() => setShowModal(false)}>
                <h3 className='font-bold mt-[8px]'>Uyarı</h3>
                <p className='leading-[16px]'>Belirtilen süreler otobüs firması tarafından iletilmektedir. Kalkış ve varış saatleri tahmini olup saat değişiklikleri biletall.com sorumluluğunda değildir</p>
                <h3 className='font-bold mt-[8px]'>Özellikler</h3>
                <ul className='flex justify-start'>
                    <li className='p-1'>
                        <WifiOutlined />
                    </li>
                    <li className='p-1'>
                        <WifiOutlined />
                    </li>
                    <li className='p-1'>
                        <WifiOutlined />
                    </li>
                    <li className='p-1'>
                        <WifiOutlined />
                    </li>
                </ul>
                <div>
                    <h3 className='font-bold mt-[8px]'>Güzergah</h3>
                    <table className='w-full'>
                        <tbody>
                            <tr>
                                <th className='text-left font-normal'>00:00</th>
                                <td>Esenler Otogarı</td>
                            </tr>
                            <tr className='bg-[#fafafa]'>
                                <th className='text-left font-normal'>01:31</th>
                                <td>Ataşehir Dudullu Terminali</td>
                            </tr>
                            <tr>
                                <th className='text-left font-normal'>02:31</th>
                                <td>Gebze Otogarı</td>
                            </tr>
                            <tr className='bg-[#fafafa]'>
                                <th className='text-left font-normal'>03:00</th>
                                <td>İzmit Otogarı</td>
                            </tr>
                            <tr>
                                <th className='text-left font-normal'>03:30</th>
                                <td>Adapazarı Otogarı</td>
                            </tr>
                            <tr className='bg-[#fafafa]'>
                                <th className='text-left font-normal'>07:30</th>
                                <td>Ankara (Aşti) Otogarı</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </Modal>
        </>
    )
}

export default ExpeditionInformation