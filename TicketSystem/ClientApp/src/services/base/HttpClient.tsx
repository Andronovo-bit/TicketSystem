import axios from "axios";

const CancelToken = axios.CancelToken;
const source = CancelToken.source();
const BaseURL = "http://localhost:5001/api/";

const axiosConfigCreator = () => {
    const config: any = {
        baseUrl: BaseURL,
    };
    return config;
};
let instance = axios.create(axiosConfigCreator());


instance.interceptors.response.use(
    (response) => {
        return response;
    },
    (error) => {

        return Promise.reject(error);
    }
);

async function get<TModel>(url: string, headers: any): Promise<TModel> {
    return instance
        .get<TModel>(url, { cancelToken: source.token, headers: headers })
        .then((response) => response.data)
        .catch((error) => {
            throw error;
        });
}

async function post<TModel>(
    url: string,
    data: any,
    headers: any
): Promise<TModel> {
    return instance
        .post<TModel>(url, data, {
            cancelToken: source.token,
            headers: headers,
        })
        .then((response) => response.data)
        .catch((error) => {
            throw error;
        });
}

export const HttpClient = { get, post };
