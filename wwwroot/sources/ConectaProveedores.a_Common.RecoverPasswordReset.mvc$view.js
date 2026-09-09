import { withBaseWebScreen, ifWidget as $if, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutBlank_mvc_view from "./ConectaProveedores.a_Layouts.LayoutBlank.mvc$view.js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Image as OSWidgets$Image, Text as OSWidgets$Text, AdvancedHtml as OSWidgets$AdvancedHtml, Label as OSWidgets$Label, Input as OSWidgets$Input, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedores_a_Common_PasswordPolicy_mvc_view from "./ConectaProveedores.a_Common.PasswordPolicy.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.RecoverPasswordReset.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.RecoverPasswordReset.mvc$controller.js";
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
extendedProperties: {
style: "height: 687px;"
},
style: "login-form loginform-telcel",
_idProps: {
service: idService,
name: "PasswordResetForm"
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
style: "heightauto",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heightauto",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_a_Common_PasswordPolicy_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Password: model.variables.newPasswordVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
compliant$Action: function (isValidIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.passwordPolicyCompliant$Action(isValidIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
_idProps: {
service: idService,
uuid: "13",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 20px;"
},
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PXZF+ZgZnEWhk+T0R02wiA#Value", "Email"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
enabled: true,
extendedProperties: {
style: "border-radius: 30px; padding-bottom: 8px; padding-left: var(--space-base); padding-right: var(--space-xl); padding-top: 8px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
inputType: /*Email*/ 7,
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CTCEM4mS2kSHcRlfDhjbUw#ValueExpression.67066748.1", "Email"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.emailVar, function (value) {
model.variables.emailVar = value;
}),
_idProps: {
service: idService,
name: "Input_Email"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: var(--space-base);"
},
style: model.getCachedValue(idService.getId("w2oUCnIum026+G1ZYWvArQ.Style"), function () {
return ("os-boxlabel login-inputs" + ((model.widgets.get(idService.getId("Input_Code")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_Code")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hcR7U+mVmUOfOqVNTP6I+A#Value", "Verification code"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
enabled: true,
extendedProperties: {
tabIndex: "1",
style: "border-radius: 30px; padding-bottom: 8px; padding-left: var(--space-base); padding-right: var(--space-xl); padding-top: 8px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_CodeOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.verificationCodeVar, function (value) {
model.variables.verificationCodeVar = value;
}),
_idProps: {
service: idService,
name: "Input_Code"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Uj+IhvSg_kabnvhtJt7UPw.Style"), function () {
return ("margin-top-base password-input os-boxlabel" + ((model.widgets.get(idService.getId("Input_NewPassword")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_NewPassword")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lGsF84pz5UqB_wgfGkHvDg#Value", "New Password"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("PasswordResetForm")
},
_idProps: {
service: idService,
uuid: "23",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onTogglePasswordVisibility$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isPasswordVisibleVar, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "eye-slash",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "eye",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
enabled: true,
extendedProperties: {
tabIndex: "2",
style: "border-radius: 30px; padding-bottom: 8px; padding-left: var(--space-base); padding-right: var(--space-xl); padding-top: 8px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
inputType: /*Password*/ 1,
mandatory: true,
maxLength: 256,
style: "form-control login-password",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.newPasswordVar, function (value) {
model.variables.newPasswordVar = value;
}),
_idProps: {
service: idService,
name: "Input_NewPassword"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.newPasswordVar), asPrimitiveValue(model.variables.isPasswordVisibleVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Eg8fZPm+P0y5LEDGqrXnWQ.Style"), function () {
return ("margin-top-base password-input os-boxlabel" + ((model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EcibhzNZ90uR1vTZNvsbsQ#Value", "Confirm Password"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("PasswordResetForm")
},
_idProps: {
service: idService,
uuid: "30",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onTogglePasswordVisibility$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isConfirmPasswordVisibleVar, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "eye-slash",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "eye",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
enabled: true,
extendedProperties: {
tabIndex: "3",
style: "border-radius: 30px; padding-bottom: 8px; padding-left: var(--space-base); padding-right: var(--space-xl); padding-top: 8px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
inputType: /*Password*/ 1,
mandatory: true,
maxLength: 256,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_ConfirmPasswordOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control login-password",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.confirmPasswordVar, function (value) {
model.variables.confirmPasswordVar = value;
}),
_idProps: {
service: idService,
name: "Input_ConfirmPassword"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.confirmPasswordVar), asPrimitiveValue(model.variables.isConfirmPasswordVisibleVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "login-button margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "35"
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
ExtendedClass: "full-width",
IsLoading: model.variables.isExecutingVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("PasswordResetForm")
},
_idProps: {
service: idService,
uuid: "36",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: model.variables.isButtonEnabledVar,
extendedProperties: {
tabIndex: "4"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("PasswordResetForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.savePasswordOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("dts0SqsIDEmyzfbQVm47gA#Value", "Change Password")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar)]
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.confirmPasswordVar), asPrimitiveValue(model.variables.isConfirmPasswordVisibleVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr), asPrimitiveValue(model.variables.isPasswordVisibleVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_NewPassword")).validAttr), asPrimitiveValue(model.variables.verificationCodeVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Code")).validAttr), asPrimitiveValue(model.variables.emailVar), asPrimitiveValue(model.variables.newPasswordVar), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.environmentOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "RecoverPasswordReset",
functionKey: "0e04d04c-3857-48b3-b59d-04051d40722c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.RecoverPasswordReset",
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
return [ConectaProveedores_a_Layouts_LayoutBlank_mvc_view, ConectaProveedores_a_Common_PasswordPolicy_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
