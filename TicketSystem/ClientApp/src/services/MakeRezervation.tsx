import { endpoints, servicesBaseUrl } from "../constants/service/ApiConstants";
import { HttpClient } from "./base/HttpClient";
import headers from "../constants/service/header.json";
import { GetRoute } from "../models/GetRoute";
import { RouteDetail } from "../models/RouteDetail";
import { BookRezervation } from "../models/BookRezervation";

export const MakeRezervation = async (data: BookRezervation): Promise<any> => {
    const url = `${servicesBaseUrl + endpoints.BUYTICKET}`;
    const config = headers.content_type.application_json;
    return HttpClient.post<any>(url, data, config);
};
