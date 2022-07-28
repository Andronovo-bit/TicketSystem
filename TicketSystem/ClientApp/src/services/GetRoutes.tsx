import { endpoints, servicesBaseUrl } from "../constants/service/ApiConstants";
import { HttpClient } from "./base/HttpClient";
import headers from "../constants/service/header.json";
import { GetRoute } from "../models/GetRoute";
import { RouteDetail } from "../models/RouteDetail";

export const GetRoutes = async (data: GetRoute): Promise<RouteDetail> => {
    const url = `${servicesBaseUrl + endpoints.GETROUTES}`;
    const config = headers.content_type.application_json;
    return HttpClient.post<any>(url, data, config);
};
