import { endpoints, servicesBaseUrl } from "../constants/service/ApiConstants";
import { HttpClient } from "./base/HttpClient";
import headers from "../constants/service/header.json";
import { GetBus } from "../models/GetBus";
import { Sefer } from "../models/Sefer";

export const GetBusDetail = async (data: GetBus): Promise<any> => {
    const url = `${servicesBaseUrl + endpoints.GETBUS}`;
    const config = headers.content_type.application_json;
    return HttpClient.post<any>(url, data, config);
};
