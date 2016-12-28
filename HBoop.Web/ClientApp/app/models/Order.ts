import { OrderDetail } from "./order.detail";
export class Order {
    public orderID: string;
    public orderDate: Date;
    public dueDate: Date;
    public shipDate: Date;
    public orderNumber: string;
    public orderDtails: OrderDetail[];
}