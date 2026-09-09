import { withBaseWebBlock, asPrimitiveValue, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.wb_OrderItemEntriesByItemId.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.wb_OrderItemEntriesByItemId.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getOrderItemEntriesByOrderMainItemidAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("o93Gl6fRBkq8IF99E0f02Q.Style"), function () {
return ((model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.quantity_Attr.gt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("sap-entry import") : ("sap-entry output"));
}, function () {
return model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.quantity_Attr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.createdOnAttr), asPrimitiveValue(model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.quantity_Attr), asPrimitiveValue(model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.materialCodeAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "sap-entry-top",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "sap-type",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
style: "bold",
value: model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.materialCodeAttr,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "sap-quantity",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: model.getCachedValue(idService.getId("jU8o7hsCCEKsqmqpClPI2w.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.quantity_Attr, 3, ".", ",");
}, function () {
return model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.quantity_Attr;
}),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "sap-date",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: model.getCachedValue(idService.getId("UNlfqMKAMEmAjD6NObtfCw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.createdOnAttr, "d MMM yyyy HH:mm");
}, function () {
return model.variables.getOrderItemEntriesByOrderMainItemidAggr.listOut.getCurrent(callContext.iterationContext).orderItemEntriesAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getOrderItemEntriesByOrderMainItemidAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderItemEntriesByOrderMainItemidAggr.dataFetchStatusAttr),
MaxRecords: model.variables.maxRecordsVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "10",
alias: "1"
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
uuid: "11"
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
uuid: "12"
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
style: "list-updating",
visible: true,
_idProps: {
service: idService,
name: "loader"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_OrderItemEntriesByItemId",
functionKey: "9ae8fce1-5918-49cd-9e27-8172c46f971f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.wb_OrderItemEntriesByItemId",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_Orders.wb_OrderItemEntriesByItemId.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
