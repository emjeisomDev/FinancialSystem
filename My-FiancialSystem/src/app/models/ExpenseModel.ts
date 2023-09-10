export class ExpenseModel {
    Id!: number;
    Name!: string;
    ExpenseValue!: number;
    Month!: number;
    Year!: number;
    TypeExpense!: number;
    RegistrationDate!: Date;
    ChangeDate!: Date;
    PaymentDate!: Date;
    DueDate!: Date;
    Paid!: boolean;
    OverdueExpense!: boolean;
    IdCategory!: number;
}
