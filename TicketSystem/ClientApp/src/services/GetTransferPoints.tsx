import { endpoints, servicesBaseUrl } from "../constants/service/ApiConstants";
import { HttpClient } from "./base/HttpClient";
import headers from "../constants/service/header.json";
import { KaraNokta } from "../models/KaraNokta";

export const GetTransferPoints = async (): Promise<any> => {
    const url = `${servicesBaseUrl + endpoints.GETTRANSFERPOINT}`;
    return HttpClient.get<any>(url, headers);
};
