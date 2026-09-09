import { withBaseWebScreen, ifWidget as $if, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import Telcel_Theme_Theme_Layouts_Layout_Blank_mvc_view from "./Telcel_Theme.Theme_Layouts.Layout_Blank.mvc$view.js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Image as OSWidgets$Image, Text as OSWidgets$Text, AdvancedHtml as OSWidgets$AdvancedHtml, Label as OSWidgets$Label, Input as OSWidgets$Input, Link as OSWidgets$Link, Checkbox as OSWidgets$Checkbox, Expression as OSWidgets$Expression, Button as OSWidgets$Button, Popup as OSWidgets$Popup, List as OSWidgets$List } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.Login.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.Login.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Theme_Layouts_Layout_Blank_mvc_view, {
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
extendedProperties: {
style: "height: 550px;"
},
gridProperties: {
width: "455px"
},
style: "login-form loginform-telcel",
_idProps: {
service: idService,
name: "LoginForm"
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
}, $if((model.variables.getSettingsEnviromentDataAct.environmentOut === "PROD"), false, this, function () {
return [];
}, function () {
return [$if((model.variables.getSettingsEnviromentDataAct.environmentOut === "DEV"), false, this, function () {
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
return [$if((model.variables.getSettingsEnviromentDataAct.environmentOut === "QA"), false, this, function () {
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
})), createElement(OSWidgets$AdvancedHtml, {
tag: "h1",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if((model.variables.stepVar === 1), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "login-inputs margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("5l3mf0AxNU+I2DF4CKUiqA.Style"), function () {
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
}, $text(getTranslation("_YyaAlYD2066Kjww8zuOdw#Value", "User"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("LoginForm")
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
validationParentId: idService.getId("LoginForm")
},
enabled: true,
extendedProperties: {
style: "border-radius: 30px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4tXuMdmtSUeEfyYLcWVkRQ#ValueExpression.67066748.1", "Email"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.userEmailVar, function (value) {
model.variables.userEmailVar = value;
}),
_idProps: {
service: idService,
name: "Input_Username"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.userEmailVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Le1G+rgorUqcfbcTCaOdFA.Style"), function () {
return ("margin-top-base password-input os-boxlabel" + ((model.widgets.get(idService.getId("Input_Password")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_Password")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("h4nPu7MY4UCuzk6eFWF_pQ#Value", "Password"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("LoginForm")
},
_idProps: {
service: idService,
uuid: "21",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
tabIndex: ((-1)).toString()
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onTogglePasswordVisibility$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.makePasswordVisibleVar, false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 20px; margin-right: 16px; margin-top: 10px;"
},
gridProperties: {
width: "24px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_blind.svg"),
style: "icon",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 20px; margin-right: 16px; margin-top: 10px;"
},
gridProperties: {
width: "24px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_eyeopen.svg"),
style: "icon",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("LoginForm")
},
enabled: true,
extendedProperties: {
style: "border-radius: 30px; padding-bottom: 8px; padding-left: var(--space-base); padding-right: var(--space-xl); padding-top: 8px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
inputType: /*Password*/ 1,
mandatory: true,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("I58UbTrsGkGm6Fd8jtHOXQ#ValueExpression.1281629883.1", "Password"),
style: "form-control login-password",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.passwordVar, function (value) {
model.variables.passwordVar = value;
}),
_idProps: {
service: idService,
name: "Input_Password"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.passwordVar), asPrimitiveValue(model.variables.makePasswordVisibleVar)]
})), $if(model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-s",
visible: model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
_this.validateWidget(idService.getId("LoginForm"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopupToSelectUser$Action(controller.callContext(eventHandlerContext));


;
},
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jX7Fuud_6EiXXHcnMqP2Uw#Value", "Click to select test user"))))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: 10px; text-align: left;"
},
style: "margin-top-l position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("LoginForm")
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.rememberMeVar, function (value) {
model.variables.rememberMeVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
classes: "ThemeGrid_Width3",
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 14px; margin-left: 10px;"
},
text: [$text(getTranslation("hNwIKPMj1EqnkuBj4+tW3w#Value", "Remember"))],
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width8",
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PU3TeXJCI0230hu5Fgi2SQ#Value.-1568054451.1", "Forgot password? Click here to recover it"),
style: "color: #0071D1;"
},
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RecoverPasswordRequest", {}),
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "color: #00529B; margin-left: 0px;"
},
style: "",
text: [$text(getTranslation("o4fJGlQZsUqJB9hJ6WlWTg#Value", "Forgot your password?"))],
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "login-button  text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.msgVar) !== ("")), false, this, function () {
return [createElement(OSWidgets$Expression, {
extendedProperties: {
style: "font-size: 14px;"
},
style: "text-red",
value: model.variables.msgVar,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "37"
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
IsLoading: model.variables.isExecutingCodeRequestVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("LoginForm")
},
_idProps: {
service: idService,
uuid: "38",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.variables.isEnabledVar,
extendedProperties: {
style: "font-size: var(--font-size-s); margin-right: 0px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("LoginForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendCodeOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("Mbx+n7aQt029oeGcjDD02A#Value", "Request code"))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isEnabledVar)]
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "login-inputs margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5X2Boso2I0iBZBiA21YHmQ#Value", "We\'ve sent a code to your email address (if an account is associated with it).\nThe code is valid for 15 minutes."))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("tVe9rdcBh0yjU08hssyDhA.Style"), function () {
return ("os-boxlabel" + ((model.widgets.get(idService.getId("Input_Usercode")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_Usercode")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_louU_xuvkKytnT6TwF1Ew#Value", "Code"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("LoginForm")
},
_idProps: {
service: idService,
uuid: "46",
alias: "5"
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
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("LoginForm")
},
enabled: true,
extendedProperties: {
style: "border-radius: 30px;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 250,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HsB_i7abxE+_9IrkuMV1OA#ValueExpression.3059181.1", "code"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.userCodeVar, function (value) {
model.variables.userCodeVar = value;
}),
_idProps: {
service: idService,
name: "Input_Usercode"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.userCodeVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "login-button margin-top-l text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
validationParentId: idService.getId("LoginForm")
},
_idProps: {
service: idService,
uuid: "50",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.variables.isEnabledCodeVar,
extendedProperties: {
style: "font-size: var(--font-size-s); margin-right: 0px;"
},
gridProperties: {
classes: "OSFillParent",
marginLeft: "0"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("LoginForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.loginOnClickSupplier$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("l7HmdBJOdEeWistyCeG2nw#Value", "Login"))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isEnabledCodeVar)]
}))];
}))), $if(model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut, false, this, function () {
return [createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showSelectUserPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "300px",
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.vertical
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
uuid: "55",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getUserExtendedInternalsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getUserExtendedInternalsAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.userOnSelect$Action(model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (((((model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) + " (") + model.variables.getUserExtendedInternalsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr) + ")"),
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), $if(false, false, this, function () {
return [];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.listOut), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.isDataFetchedAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pz6az2PnK0ydk66fS8JIYw#Value", "Close")))))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.listOut), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.showSelectUserPopupVar), asPrimitiveValue(model.variables.isEnabledCodeVar), asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.userCodeVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Usercode")).validAttr), asPrimitiveValue(model.variables.isEnabledVar), asPrimitiveValue(model.variables.isExecutingCodeRequestVar), asPrimitiveValue(model.variables.msgVar), asPrimitiveValue(model.variables.rememberMeVar), asPrimitiveValue(model.variables.passwordVar), asPrimitiveValue(model.variables.makePasswordVisibleVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Password")).validAttr), asPrimitiveValue(model.variables.userEmailVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Username")).validAttr), asPrimitiveValue(model.variables.stepVar), asPrimitiveValue(model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut), asPrimitiveValue(model.variables.getSettingsEnviromentDataAct.environmentOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "Login",
functionKey: "186fee31-890e-4e40-9f53-fcd0517678cc",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.Login",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.a_Common.Login.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [Telcel_Theme_Theme_Layouts_Layout_Blank_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view];
};


return ELEM;
};

export default componentFactory()
