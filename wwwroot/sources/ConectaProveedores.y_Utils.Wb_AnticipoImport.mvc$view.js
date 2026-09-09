import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_AnticipoImport.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_AnticipoImport.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.importAnticipoIn.gt(OS$BuiltinFunctions.integerToDecimal(0)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m padding-s",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #eb9100;"
},
icon: "exclamation-triangle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("RiDnQlhiSUuR72bMHCz0hg.Value"), function () {
return (((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fZ1zkk+ZZUSb2eZPmcN9Gg#ValueExpression.-1289882106.1", "This invoice has an anticipo amortization value of") + " ") + OS$BuiltinFunctions.formatDecimal(model.variables.importAnticipoIn, 2, ".", ",")) + ".");
}, function () {
return model.variables.importAnticipoIn;
}),
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._importAnticipoInDataFetchStatus)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gYr5EHTJF02WbRvgtah7zg#ValueExpression.265551664.1", "To proceed, please upload an invoice with field TipoRelacion 07 or upload a credit note."),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_AnticipoImport",
functionKey: "43f9f2b4-192d-4846-8d87-dd5575d2789f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_AnticipoImport",
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
return [];
};


return ELEM;
};

export default componentFactory()
