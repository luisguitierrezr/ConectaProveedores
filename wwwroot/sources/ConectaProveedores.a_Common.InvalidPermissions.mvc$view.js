import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import OutSystemsUI_Content_BlankSlate_mvc_view from "./OutSystemsUI.Content.BlankSlate.mvc$view.js";
import { Icon as OSWidgets$Icon, Container as OSWidgets$Container, Text as OSWidgets$Text, Link as OSWidgets$Link } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.a_Common.InvalidPermissions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.InvalidPermissions.mvc$controller.js";
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: Widget.PlaceholderContent.Empty,
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Content_BlankSlate_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FullHeight: true
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
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "lock",
iconSize: /*FontSize*/ 0,
style: "icon text-neutral-4",
visible: true,
_idProps: {
service: idService,
name: "Icon1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "heading6",
text: [$text(getTranslation("33gIhDYS6E6qIKReu+2PmA#Value", "You don\'t have the necessary permission to see this screen."))],
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QGbT7R8uHkmdaWHw9qRphw#Value", "Please contact your system administrator.")))];
}),
actions: new Widget.PlaceholderContent(function () {
return [$if((OS$BuiltinFunctions.getUserId() === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
tabIndex: "1"
},
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}),
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ok0_TnXGtUi0Kpgc0Z60Pg#Value", "Go to login")))];
}, function () {
return [];
})];
})
},
_dependencies: []
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: []
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "InvalidPermissions",
functionKey: "2b4875e6-4842-4a90-bbe5-5e12808a4563",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.InvalidPermissions",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Content_BlankSlate_mvc_view];
};


return ELEM;
};

export default componentFactory()
