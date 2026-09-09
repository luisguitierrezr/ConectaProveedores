import { withBaseWebBlock, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Model as OS$Model } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Layouts_Custom_Layout_Top_Menu_mvc_view from "./Telcel_Theme.Theme_Layouts.Custom_Layout_Top_Menu.mvc$view.js";
import ConectaProveedores_a_Common_Menu_mvc_view from "./ConectaProveedores.a_Common.Menu.mvc$view.js";
import { createElement } from "react";
import { Placeholder as OSWidgets$Placeholder } from "@outsystems/runtime-widgets-js";
import ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view from "./ConectaProveedores.y_Utils.wb_LoadingLayer.mvc$view.js";
import Telcel_FloatingChatUILib_UIPatterns_FloatingChat_mvc_view from "./Telcel_FloatingChatUILib.UIPatterns.FloatingChat.mvc$view.js";
import ConectaProveedores_y_Utils_CopilotChat_mvc_view from "./ConectaProveedores.y_Utils.CopilotChat.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Theme_Layouts_Custom_Layout_Top_Menu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
EnableAccessibilityFeatures: model.variables.enableAccessibilityFeaturesIn,
_enableAccessibilityFeaturesInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._enableAccessibilityFeaturesInDataFetchStatus),
HasFixedHeader: model.variables.hasFixedHeaderIn,
_hasFixedHeaderInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._hasFixedHeaderInDataFetchStatus),
ExtendedClass: model.variables.extendedClassIn,
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._extendedClassInDataFetchStatus)
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
header: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_a_Common_Menu_mvc_view, {
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
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.breadcrumbs,
style: "content-breadcrumbs placeholder-empty",
_idProps: {
service: idService,
name: "Breadcrumbs"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.mainContent,
_idProps: {
service: idService,
name: "MainContent"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Placeholder, {
align: /*Default*/ 0,
content: _this.props.placeholders.footer,
style: "placeholder-empty",
_idProps: {
service: idService,
name: "Footer"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view, {
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
uuid: "5",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(Telcel_FloatingChatUILib_UIPatterns_FloatingChat_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsEnabled: model.variables.chatBotIsEnableIn,
_isEnabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._chatBotIsEnableInDataFetchStatus),
AssistantName: "Conect Proveedores ",
StartsOpen: false
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
uuid: "6",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
placeholder: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_CopilotChat_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: model.variables.initiativeIn,
_initiativeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._initiativeInDataFetchStatus)
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
uuid: "7",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables._initiativeInDataFetchStatus), asPrimitiveValue(model.variables.initiativeIn)]
})];
})];
})
}
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "CustomLayoutTopMenu",
functionKey: "8f58630d-61bc-4f95-943d-bc96166fb34a",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Layouts.CustomLayoutTopMenu",
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
return [Telcel_Theme_Theme_Layouts_Custom_Layout_Top_Menu_mvc_view, ConectaProveedores_a_Common_Menu_mvc_view, ConectaProveedores_y_Utils_wb_LoadingLayer_mvc_view, Telcel_FloatingChatUILib_UIPatterns_FloatingChat_mvc_view, ConectaProveedores_y_Utils_CopilotChat_mvc_view];
};


return ELEM;
};

export default componentFactory()
