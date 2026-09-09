import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ModelFactory from "./ConectaProveedores.a_Common.PasswordPolicy.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.PasswordPolicy.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((((((model.variables.passwordComplexityPolicyVar.minimumLengthAttr > 0) || model.variables.passwordComplexityPolicyVar.upperCaseLetterRequiredAttr) || model.variables.passwordComplexityPolicyVar.lowerCaseLetterRequiredAttr) || model.variables.passwordComplexityPolicyVar.numberRequiredAttr) || model.variables.passwordComplexityPolicyVar.specialCharacterRequiredAttr), false, this, function () {
return [$if(model.variables.getMaxSavedOldPasswordsDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-size-xs",
visible: true,
_idProps: {
service: idService,
uuid: "0"
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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y9X+9WRVDUWPSWfZPKEEKg#Value", "Your password must contain:"))), $if(model.variables.passwordComplexityPolicyVar.numberRequiredAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("DpATMi9xfUGOHmCmDDD5Fw.Style"), function () {
return ((model.variables.passwordValidationResultVar.missingMinimumLengthAttr) ? ("") : ("text-green-darker"));
}, function () {
return model.variables.passwordValidationResultVar.missingMinimumLengthAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.passwordValidationResultVar.missingMinimumLengthAttr, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("t_Nhc1Yi_0ufujAlOJsfSg#Value", "At least")), createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
value: ((" " + (model.variables.passwordComplexityPolicyVar.minimumLengthAttr).toString()) + " "),
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("Pz4arQwR2Uqo+hHwGbixCQ#Value", "characters"))))];
}, function () {
return [];
}), $if(model.variables.passwordComplexityPolicyVar.upperCaseLetterRequiredAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("y9fQ6AvfmEO5D1RWD5DIuw.Style"), function () {
return ((model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr) ? ("") : ("text-green-darker"));
}, function () {
return model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.passwordValidationResultVar.missingUpperCaseLetterAttr, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bhHhNBRrTEGKNKyygKQ7wg#Value", "1 uppercase letter"))))];
}, function () {
return [];
}), $if(model.variables.passwordComplexityPolicyVar.lowerCaseLetterRequiredAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("gQnC8djmiEmP0+qjRBMZxA.Style"), function () {
return ((model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr) ? ("") : ("text-green-darker"));
}, function () {
return model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.passwordValidationResultVar.missingLowerCaseLetterAttr, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NlTH8spaZUSWMVXfEaVAUw#Value", "1 lowercase letter"))))];
}, function () {
return [];
}), $if(model.variables.passwordComplexityPolicyVar.numberRequiredAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("zO9RsztqNUOqB+lVn3OsFA.Style"), function () {
return ((model.variables.passwordValidationResultVar.missingNumberAttr) ? ("") : ("text-green-darker"));
}, function () {
return model.variables.passwordValidationResultVar.missingNumberAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.passwordValidationResultVar.missingNumberAttr, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4+DI0bVE_UG3nWjE3MKZuw#Value", "1 number"))))];
}, function () {
return [];
}), $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("CSFNSF410UWExI8hLgSffw.Style"), function () {
return ((model.variables.isMissingSpecialCharacterVar) ? ("") : ("text-green-darker"));
}, function () {
return model.variables.isMissingSpecialCharacterVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isMissingSpecialCharacterVar, false, this, function () {
return [createElement(OSWidgets$Icon, {
icon: "times-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Icon, {
icon: "check-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RNg09K79SUmhz3Kw7MAqKg#Value", "1 special character (ex: !, @, #, $, %)"))))];
}, function () {
return [];
}), $if((model.variables.getMaxSavedOldPasswordsDataAct.valueOut > 0), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "info-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SWYDvNUNHEKXq_LIF_Wo8Q#ValueExpression.-1397490257.1", "It can\'t be one of the last") + " ") + (model.variables.getMaxSavedOldPasswordsDataAct.valueOut).toString()) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SWYDvNUNHEKXq_LIF_Wo8Q#ValueExpression.1005940521.1", "passwords used.")),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMaxSavedOldPasswordsDataAct.dataFetchStatusAttr)
})))];
}, function () {
return [];
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}, function () {
return [];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "PasswordPolicy",
functionKey: "48bd8685-fd2c-4bfa-90ec-6f72100ea20e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.PasswordPolicy",
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
