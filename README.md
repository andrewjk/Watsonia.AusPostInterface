# Australia Post Client

C# functions for working with Australia Post's Shipping and Tracking API outlined at https://developers.auspost.com.au/.  

There is enough in here so far to create and dispatch an order as per https://developers.auspost.com.au/apis/shipping-and-tracking/tutorial/more-integrated-solution.  

Functions are implemented in the ShippingClient class and include:

* GetAccountsAsync
* CreateShipmentsAsync
* UpdateItemsAsync
* DeleteItemsAsync
* DeleteShipmentAsync
* CreateOrderFromShipmentsAsync
* CreateOrderIncludingShipmentsAsync
* CreateLabelsAsync
* DownloadLabelsAsync
* GetOrdersAsync
* GetShipmentsAsync
* GetOrderSummaryAsync

## License ##

Australia Post Client is released under the terms of the [MIT License](http://opensource.org/licenses/MIT).
