import { withBaseWebScreen, ifWidget as $if, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutBlank_mvc_view from "./ConectaProveedores.a_Layouts.LayoutBlank.mvc$view.js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Image as OSWidgets$Image, Text as OSWidgets$Text, AdvancedHtml as OSWidgets$AdvancedHtml, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.RecoverPasswordRequest.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.RecoverPasswordRequest.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutBlank_mvc_view, {
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
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "login-screen",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
style: "login-form loginform-telcel",
_idProps: {
service: idService,
name: "RecoverPasswordForm"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: 10px; margin-top: 0px; text-align: center;"
},
style: "login-logo",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
alt: ""
},
gridProperties: {
width: "99.648px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Light.svg"),
style: "TelcelLogo",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((OS$BuiltinFunctions.trim(model.variables.getSettingsEnviromentDataAct.environmentOut) === "PROD"), false, this, function () {
return [];
}, function () {
return [$if((OS$BuiltinFunctions.trim(model.variables.getSettingsEnviromentDataAct.environmentOut) === "DEV"), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "flag-isdev",
text: ["DEV"],
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if((OS$BuiltinFunctions.trim(model.variables.getSettingsEnviromentDataAct.environmentOut) === "QA"), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "flag-isqa",
text: ["QA"],
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
})];
}))), createElement(OSWidgets$AdvancedHtml, {
extendedProperties: {
className: "margin-top-base"
},
tag: "h1",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "color: #00529B; margin-top: -10px;"
},
style: "LoginTelcelText",
text: ["Portal Conecta Proveedores"],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 50px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "color: var(--color-primary; margin-left: 0px; margin-top: 0px;"
},
style: "",
text: [$text(getTranslation("QL2fSjXloE66bwAwgrSiGQ#Value", "Have you forgotten your password?"))],
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 50px;"
},
style: model.getCachedValue(idService.getId("rK9I94NbGESxj7P3jRjwLA.Style"), function () {
return ("os-boxlabel" + ((model.widgets.get(idService.getId("Input_Username")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_Username")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0qDahkFo70yd2XgILscoCA#Value", "Email"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("RecoverPasswordForm")
},
_idProps: {
service: idService,
uuid: "15",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 20px; margin-right: 16px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_at.png"),
style: "icon",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("RecoverPasswordForm")
},
enabled: true,
extendedProperties: {
style: "border-radius: 30px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HwWscoOBdEWndiT6vWaTMg#ValueExpression.67066748.1", "Email"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.emailVar, function (value) {
model.variables.emailVar = value;
}),
_idProps: {
service: idService,
name: "Input_Username"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.emailVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "login-button margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsLoading: model.variables.isExecutingVar,
ExtendedClass: "full-width"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("RecoverPasswordForm")
},
_idProps: {
service: idService,
uuid: "19",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: model.variables.isButtonEnabledVar,
extendedProperties: {
tabIndex: "2"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("RecoverPasswordForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.resetPasswordOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("fMxHCEqRXE2qWwxM4aE_nA#Value", "Recover")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar)]
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.emailVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Username")).validAttr), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.environmentOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "RecoverPasswordRequest",
functionKey: "3fea9ba6-0c6b-4fe7-ab2e-65022a9839c0",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.RecoverPasswordRequest",
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
return [ConectaProveedores_a_Layouts_LayoutBlank_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
