export class OrderSummary{
    public salesOrderID: number;
    public orderDate: Date;
    public shipDate: Date;
    public dueDate: Date;
    public salesOrderNumber: string;
    public BeneficiaryID: string;
    public totalDue: number;
    public lines: number;
}