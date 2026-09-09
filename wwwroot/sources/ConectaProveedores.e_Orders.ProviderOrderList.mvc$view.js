import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Link as OSWidgets$Link, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, DataConversion as OS$DataConversion, Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.ProviderOrderList.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.ProviderOrderList.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: "FCP",
ChatBotIsEnable: true
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("nQttgcK4cUuP1z1RMMwRaw#Value", "My Requests"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2P8JdSSNCUKMwQVqem2mvA#Value", "Order Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tHBvpUilmkqtKjLtbuFzJw#ValueExpression.69519515.1", "Order Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderProviderList_Number(), function (value) {
ConectaProveedoresClientVariables.setOrderProviderList_Number(value);
}),
_idProps: {
service: idService,
name: "Input_Number"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 700,
WidgetId: idService.getId("Input_Number")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "6",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getOrdersAggr.isDataFetchedAttr && (!(model.variables.getOrdersAggr.hasFetchErrorAttr))), false, this, function () {
return [$if((model.variables.getOrdersAggr.isDataFetchedAttr && model.variables.getOrdersAggr.listOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("c_N1j5v3AkehfZQVHQDnkQ#Value", "No orders were found."))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getOrdersAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tAf8DO89t0CXlqmt7HfZsQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Company.Description",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wA4LuQ7_P0mUpU+ZhQWRFg#Value", "Client"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.TotalAmount",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("GRREFIbq7kiwRFM9+9kx4g#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("RYsQJCLtOUiivU88+N6BCA#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderDate",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dqv0R7MroEabnGMml07yPA#Value", "Order Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
sortAttribute: "OrderMain.OrderStatusId",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hXPoGZZ0+kSTlfY0cACm2w#Value", "Order Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDetail", {
i_OrderId: OS$DataConversion.ServerDataConverter.to(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("maci2QidRUKlJiwV838TjA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("dwjSD+MmFE+AOD6Wvg3OzQ.Value"), function () {
return ((model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.dateToText(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr)));
}, function () {
return model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.classAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr),
i_Text: model.variables.getOrdersAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
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
uuid: "29",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr)]
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getOrdersAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersAggr.dataFetchStatusAttr)
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
uuid: "31",
alias: "4"
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
uuid: "32",
alias: "5"
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
uuid: "33"
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
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.getOrdersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersAggr.countOut), asPrimitiveValue(model.variables.getOrdersAggr.listOut), asPrimitiveValue(model.variables.getOrdersAggr.hasFetchErrorAttr), asPrimitiveValue(model.variables.getOrdersAggr.isDataFetchedAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getOrderProviderList_Number())]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProviderOrderList",
functionKey: "edd92b29-1ce1-43e8-af06-2d21e347cdcb",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.ProviderOrderList",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view];
};


return ELEM;
};

export default componentFactory()
