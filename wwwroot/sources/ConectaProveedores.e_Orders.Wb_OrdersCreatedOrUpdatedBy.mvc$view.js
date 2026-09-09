import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_OrdersCreatedOrUpdatedBy.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_OrdersCreatedOrUpdatedBy.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "italic text-align-right",
visible: model.getCachedValue(idService.getId("KDMe+k9zH0SdquDMGjkvTA.Visible"), function () {
return (((model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.createdByAttr) !== ((OS$BuiltinFunctions.nullIdentifier()).toString())) && !(model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.createdOnAttr.equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.createdByAttr;
}, function () {
return model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsOrdersDataDataAct.dataFetchStatusAttr)
}, $if((model.variables.getsOrdersDataDataAct.isDataFetchedAttr && (!(model.variables.getsOrdersDataDataAct.hasFetchErrorAttr))), false, this, function () {
return [$if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: ((model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.updatedByAttr) !== ("")),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsOrdersDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("_vBPGEKTJkS0dm4XFBr58Q.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BGaLYDVCrEC4I+D8j1Yi5A#ValueExpression.1853933958.1", "Last updated by") + " ") + model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.updatedByAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.updatedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.updatedByAttr;
}, function () {
return model.variables.getsOrdersDataDataAct.o_OrderCreatedLogOut.updatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsOrdersDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrdersCreatedOrUpdatedBy",
functionKey: "fec9794a-969d-4473-9b44-ada50a5a66a3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_OrdersCreatedOrUpdatedBy",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
