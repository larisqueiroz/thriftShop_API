namespace thriftShop_API.Enums;

public enum OrderStatus
{
    WAITINGCONFIRMATION,
    WAITINGPAYMENT,
    ACCEPTEDPAYMENT,
    ONSELECTION,
    ONROUTE,
    DELIVERED
}