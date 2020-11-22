import {Delivery} from "./delivery";
import {Payment} from "./payment";
import {OrderProduct} from "./order-product";

export class Order {
    productOrders:OrderProduct[] = [];
    price:number;
    name:string;
    number:string;
    address:string;
    deliveryTypeId:Delivery;
    paymentTypeId:Payment;
}