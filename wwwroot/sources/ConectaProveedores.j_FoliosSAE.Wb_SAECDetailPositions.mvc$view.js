import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image, Label as OSWidgets$Label, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECDetailPositions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SAECDetailPositions.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, $if(model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-align-center",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DPjy8KEYWEGd2hcFAW5IKQ#ValueExpression.1811764661.1", "There are no folio items associated with this folio"),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFolioItemsByFolioIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.OrderNumber",
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("vwLCUL7vkE29+f3lCuv_Kw#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderMainItem.Position",
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2bnoZnGDZUK_MaINySwGuw#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.ArticleNumber",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yopECmGVd0eY0uucxGTM0A#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.InputationCode",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("U3cm_BMWOUKc9gYvtTbkGw#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.PEP",
style: model.getCachedValue(idService.getId("3vlI1swKzk66J1l4Oo+mgg.Style"), function () {
return (((model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
_dependencies: []
}, $text(getTranslation("XXdchFjmwEiLRnWsLh9zeQ#Value", "PEP Element"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.Description",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("U_en7ywH2ka_Lt5PGO4U1Q#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "FolioItems.InvoiceQtt",
style: "",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("AtE8ErkND0CWkEcdl7luRw#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.UnitPrice",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("14wEZPFlSUycrS3vRG7TpQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "FolioItems.TotalPrice",
style: "",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XEHoGuNK2EiGJXtIsSM6rQ#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.DeliveryDate",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("t4fAPYsHCECZPq94KMbGag#Value", "Delivery Date")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr)]
}, $if(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "16",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_mosaico.svg"),
style: "margin-right-s",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Múltiple imputación"];
})
},
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr).toString(),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("kTcTNU3KIEuLWJAUBy7bYw.Style"), function () {
return (((model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.pEPAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.pEPAttr,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("pCl0IQDsXUuR9P4wS_IMKw.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5eUFj4EIQUayxBBI3babrQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr;
}),
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("t0DOvhlmBkOQkbBkAEVCpA.Value"), function () {
return ((!(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.dateToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr)) : ("-"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr;
}),
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "IsTableLoadingOrEmpty2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr && model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ao9YrfkbRUSDEsY8yor_+w#Value", "No items to show...")))];
}, function () {
return [$if((!(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between font-size-base margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
style: "text-neutral-10 margin-right-base",
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pIXHA73frkSfkwGZ_xFysA#Value", "Total")))), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "bold",
value: model.getCachedValue(idService.getId("NkymKP1UEUKSXFfydpzRlw.Value"), function () {
return ((OS$BuiltinFunctions.formatDecimal(model.variables.i_TotalAmountIn, 2, ".", ",") + " ") + model.variables.i_CurrencyCodeIn);
}, function () {
return model.variables.i_TotalAmountIn;
}, function () {
return model.variables.i_CurrencyCodeIn;
}),
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_TotalAmountInDataFetchStatus, model.variables._i_CurrencyCodeInDataFetchStatus)
})), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
MaxRecords: model.variables.maxRecordsVar,
TotalCount: model.variables.getFolioItemsByFolioIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "49",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SAECDetailPositions",
functionKey: "8904c919-ead1-46bb-800c-82cad7b477c5",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SAECDetailPositions",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
