import {Delivery} from "./delivery";
import {Payment} from "./payment";
import {OrderProduct} from "./order-product";

export interface Order {
    products:OrderProduct[];
    price:number;
    clientName:string;
    clientNumber:string;
    clientAddress:string;
    deliveryId:Delivery;
    paymentId:Payment;
}