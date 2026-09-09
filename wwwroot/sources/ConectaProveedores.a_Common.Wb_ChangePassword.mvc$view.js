import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Container as OSWidgets$Container, Text as OSWidgets$Text, Label as OSWidgets$Label, Input as OSWidgets$Input, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Common_PasswordPolicy_mvc_view from "./ConectaProveedores.a_Common.PasswordPolicy.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.Wb_ChangePassword.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.Wb_ChangePassword.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("CvYD9mjwH0uy0ruLvGGtHA#Value", "Change your password"))],
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("d9uasXKHPUqi6DuiAzp7lA.Style"), function () {
return ("margin-top-base os-boxlabel" + ((model.widgets.get(idService.getId("Input_OldPassword")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_OldPassword")).validAttr;
}),
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
mandatory: true,
targetWidget: "Input_OldPassword",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BUr7zJtmkEaIKYb5WBCbAg#Value", "Current password"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
autoComplete: "current-password",
tabIndex: "1"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Password*/ 1,
mandatory: true,
maxLength: 256,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_OldPasswordOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.oldPasswordVar, function (value) {
model.variables.oldPasswordVar = value;
}),
_idProps: {
service: idService,
name: "Input_OldPassword"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "heightauto",
visible: true,
_idProps: {
service: idService,
uuid: "6"
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
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "7",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("hcyCquQPwkKbJvFIlI4acA.Style"), function () {
return ("margin-top-base password-input os-boxlabel" + ((model.widgets.get(idService.getId("Input_NewPassword")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_NewPassword")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0ffCYlezBkaRrQwoMw9ZOg#Value", "New Password"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "10",
alias: "2"
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
uuid: "11"
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
uuid: "12"
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
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
autoComplete: "new-password",
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
style: model.getCachedValue(idService.getId("pC4tcxV__EWU5KoO4eU2Tg.Style"), function () {
return ("margin-top-base password-input os-boxlabel" + ((model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("Input_ConfirmPassword")).validAttr;
}),
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
}, $text(getTranslation("psDxrsFBOEKU9AsIogvYpg#Value", "Confirm Password"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "17",
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
uuid: "18"
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
uuid: "19"
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
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
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: " width: unset"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: true,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopUp$Action(controller.callContext(eventHandlerContext));


;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4_THhohtBkedqNUF3rJIDQ#Value", "Close")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width8 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "25"
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
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "26",
alias: "4"
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
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.setNewPasswordOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("upVS+oHrR0OHrb8J5drqfA#Value", "Set new password")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar)]
})))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ChangePassword",
functionKey: "36e0d375-0458-4567-8e2d-8dbeb791e2ef",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.Wb_ChangePassword",
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
return [ConectaProveedores_a_Common_PasswordPolicy_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
