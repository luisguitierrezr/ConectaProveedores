import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsItems.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsItems.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getInvoiceItemsByInvoiceIdAggr.isDataFetchedAttr && (!(model.variables.getInvoiceItemsByInvoiceIdAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((!(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
name: "TableSettings"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setColumnVisiblityOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "OpenPopupLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-semi-bold italic",
text: [$text(getTranslation("aAlXOhOS_0ynp4LHjhUtmQ#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "4",
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
source: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "InvoiceItemsTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PP59vs0SXE6Y3lxHy1bYUg#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtendedItem.ProductNumber",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4BLrk8zaJ0e+SSJo65jIMA#Value", "Product Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtendedItem.Description",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("grnSeY_4d0qIPbnGT7G4GQ#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Requisition.Name",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("610uuHg_rEeZnIqQYSUmRg#Value", "Requisition"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtendedItem.MaterialCode",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4cs6H5P5uEqNhAs68BrMww#Value", "Material Code"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("O28bTS9DA0WKUiczrvnm3g#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceExtendedItem.UnityPrice",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pAyi13jbg06pFW0oqOM1PA#Value", "Unity Price"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4VDYUYDqFkWD+fw8Qoj50Q#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3g9LJD28b0iGE5P8qShqgg#Value", "Currency")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.productNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.productNumberAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.materialCodeAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: (model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.quantityAttr).toString(),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.unityPriceAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("WHWK+gNx_k+J3Zy3arXpFw.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.unityPriceAttr, "", 2, ".", ",");
}, function () {
return model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.unityPriceAttr;
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.unityPriceAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(OS$BuiltinFunctions.integerToDecimal(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.quantityAttr).times(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceExtendedItemAttr.unityPriceAttr)),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("InvoiceItemsTable"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
ConfigColumnJSON: model.variables.l_ColumnJSONVarVar,
PopupBtnId: idService.getId("OpenPopupLink")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
passColumnObj$Action: function (columnJSONIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.columnTogglerPassColumn$Action(columnJSONIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "33",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getInvoiceItemsByInvoiceIdAggr.listOut.length),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceItemsByInvoiceIdAggr.dataFetchStatusAttr),
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar
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
uuid: "34",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "35",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "36"
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
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center card",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("GPLVI825Z0Sop8pXBRZCUA#Value", "No items were found in this invoice."))],
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceDetailsItems",
functionKey: "d6e9cf83-fc2f-4c76-86ef-c78fb03cf3e3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoiceDetailsItems",
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
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view];
};


return ELEM;
};

export default componentFactory()
