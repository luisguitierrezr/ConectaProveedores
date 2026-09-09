import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Link as OSWidgets$Link, Form as OSWidgets$Form, Container as OSWidgets$Container, Image as OSWidgets$Image, Label as OSWidgets$Label, Input as OSWidgets$Input, Expression as OSWidgets$Expression, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import OutSystemsUI_Interaction_AnimatedLabel_mvc_view from "./OutSystemsUI.Interaction.AnimatedLabel.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view from "./ConectaProveedores.a_Common.Wb_TempRoleAssignments.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.UserProfile_DEPRECATED.mvc$controller.js";
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
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("EOmJ12ckm02rdewtNLX2Rg#Value", "Your profile"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: new Widget.PlaceholderContent(function () {
return [$if(model.variables.isExternalVar, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ChangePassword", {}),
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("d+nlc8NYmUitixGDekMLdA#Value", "Change your password")))];
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form card",
_idProps: {
service: idService,
name: "ProfileDetailsForm"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GutterSize: ConectaProveedores_staticEntities_gutterSize.medium,
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 150px; margin-bottom: var(--space-m); text-align: center;"
},
visible: true,
_idProps: {
service: idService,
name: "divPhoto"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr) !== ("")), false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: ConectaProveedoresClientVariables.getUserName(),
alt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uJqBog+0YUuvK+Az+gx1Xw#Value.2121520573.1", "User photo"),
style: "height: 150px;"
},
gridProperties: {
width: "150px"
},
style: "img-circle img-cover",
type: /*External*/ 1,
url: model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
url_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
alt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rqaMh0CXSE62e53Hq9fTJA#Value.-1628089456.1", "User photo placeholder"),
style: "height: 150px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/ConectaProveedores.User.png"),
style: "img-circle img-cover",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("divName.Style"), function () {
return ("margin-top-base os-boxlabel" + ((model.widgets.get(idService.getId("NameInput")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("NameInput")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "divName"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "NameInput",
_idProps: {
service: idService,
name: "NameLabel"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7kZLheBChkSITYqfcY_Vmg#Value", "Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: (!(model.variables.isExternalVar)),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.validateInputsOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "NameInput"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 10px;"
},
style: model.getCachedValue(idService.getId("divPhotoURL.Style"), function () {
return ("margin-top-base os-boxlabel" + ((model.widgets.get(idService.getId("PhotoUrlInput")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("PhotoUrlInput")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "divPhotoURL"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "PhotoUrlInput",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5OPV_e4k3k2pAbc7Z5tbkQ#Value", "Photo URL"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: (!(model.variables.isExternalVar)),
extendedEvents: {
onBlur: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.validateInputsOnChange$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
autoComplete: "new-photourl"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 2048,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr = value;
}),
_idProps: {
service: idService,
name: "PhotoUrlInput"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("divEmail.Style"), function () {
return ("margin-top-base os-boxlabel" + ((model.widgets.get(idService.getId("EmailInput")).validAttr) ? ("") : (" os-error")));
}, function () {
return model.widgets.get(idService.getId("EmailInput")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "divEmail"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "EmailInput",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nYkQ4kcL7kiwVFrws1MfAA#Value", "Email"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: (!(model.variables.isExternalVar)),
extendedProperties: {
autoComplete: "new-password"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: true,
maxLength: 256,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.validateInputsOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, function (value) {
model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr = value;
}),
_idProps: {
service: idService,
name: "EmailInput"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserDetailsAggr.dataFetchStatusAttr)
})), $if(model.variables.showGetCodeButtonVar, false, this, function () {
return [$if(model.variables.showVerificationCodeVar, false, this, function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GutterSize: ConectaProveedores_staticEntities_gutterSize.none,
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
ExtendedClass: "align-items-center"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "17",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "padding-right-base",
visible: true,
_idProps: {
service: idService,
name: "divVerificationCode"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_AnimatedLabel_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "19",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
label: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.variables.showGetCodeButtonVar,
targetWidget: "VerificationCodeInput",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mofYCM00ekWvSwNTVxUP0A#Value", "Verification code")))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
enabled: true,
extendedProperties: {
autoComplete: "new-validationcode"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: model.variables.showGetCodeButtonVar,
maxLength: 6,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.validateInputsOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.verificationCodeVar, function (value) {
model.variables.verificationCodeVar = value;
}),
_idProps: {
service: idService,
name: "VerificationCodeInput"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.verificationCodeVar), asPrimitiveValue(model.variables.showGetCodeButtonVar)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: (model.variables.countdownValueVar <= 0),
extendedProperties: {
style: "margin-bottom: 0px;"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendVerificationCode$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.countdownValueVar > 0), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Gu4G3pcxUkOsM3kfamc8eA#ValueExpression.-482764862.1", "Didn’t get it? Resend in ") + (model.variables.countdownValueVar).toString()) + "s"),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OPihUF12MUKPda5DKaC7hQ#ValueExpression.1971706957.1", "Resend verification code"),
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.countdownValueVar), asPrimitiveValue(model.variables.verificationCodeVar), asPrimitiveValue(model.variables.showGetCodeButtonVar)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "DivGetVerificationCode"
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
ShowLabelOnLoading: true,
IsLoading: model.variables.isExecuting_GetCodeVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "26",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: (model.variables.showGetCodeButtonVar && (!(model.variables.showVerificationCodeVar))),
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("ProfileDetailsForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendVerificationCode$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-small",
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
}), $text(getTranslation("5ldB1vZP00mu0sQtSTdiJw#Value", "Get verification code")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.showVerificationCodeVar), asPrimitiveValue(model.variables.showGetCodeButtonVar)]
}))];
})];
}, function () {
return [];
}), $if(model.variables.isExternalVar, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
name: "divSaveChanges"
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
ShowLabelOnLoading: true,
IsLoading: model.variables.isExecutingVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
name: "btnSaveChanges",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: model.variables.isButtonEnabledVar,
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("ProfileDetailsForm"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveChangesOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
name: "btnSave"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("R8y2v4+qhECG7+hSRUKZ_g#Value", "Save changes")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isButtonEnabledVar)]
}))];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if((model.variables.getApplicationRolesAggr.isDataFetchedAttr && (!(model.variables.getApplicationRolesAggr.listOut.isEmpty))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("ProfileDetailsForm")
},
_idProps: {
service: idService,
uuid: "34",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getApplicationRolesAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getApplicationRolesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.isExecuting_GetCodeVar), asPrimitiveValue(model.variables.countdownValueVar), asPrimitiveValue(model.variables.verificationCodeVar), asPrimitiveValue(model.variables.showVerificationCodeVar), asPrimitiveValue(model.variables.showGetCodeButtonVar), asPrimitiveValue(model.widgets.get(idService.getId("EmailInput")).validAttr), asPrimitiveValue(model.widgets.get(idService.getId("PhotoUrlInput")).validAttr), asPrimitiveValue(model.variables.isExternalVar), asPrimitiveValue(model.widgets.get(idService.getId("NameInput")).validAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getUserName()), asPrimitiveValue(model.variables.getApplicationRolesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr)]
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getApplicationRolesAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getApplicationRolesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.isButtonEnabledVar), asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.isExecuting_GetCodeVar), asPrimitiveValue(model.variables.countdownValueVar), asPrimitiveValue(model.variables.verificationCodeVar), asPrimitiveValue(model.variables.showVerificationCodeVar), asPrimitiveValue(model.variables.showGetCodeButtonVar), asPrimitiveValue(model.widgets.get(idService.getId("EmailInput")).validAttr), asPrimitiveValue(model.widgets.get(idService.getId("PhotoUrlInput")).validAttr), asPrimitiveValue(model.widgets.get(idService.getId("NameInput")).validAttr), asPrimitiveValue(ConectaProveedoresClientVariables.getUserName()), asPrimitiveValue(model.variables.getApplicationRolesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserDetailsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr), asPrimitiveValue(model.variables.isExternalVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "UserProfile_DEPRECATED",
functionKey: "4670e421-f55f-444a-aae6-47f5ad9c118d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.UserProfile_DEPRECATED",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_AnimatedLabel_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view, ConectaProveedores_a_Common_Wb_TempRoleAssignments_mvc_view];
};


return ELEM;
};

export default componentFactory()
