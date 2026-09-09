import { withBaseWebBlock, ifWidget as $if, asPrimitiveValue, Widget, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Image as OSWidgets$Image, Link as OSWidgets$Link, TextArea as OSWidgets$TextArea, Icon as OSWidgets$Icon, Checkbox as OSWidgets$Checkbox, Text as OSWidgets$Text, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import { createElement } from "react";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { SE_size as ConectaProveedores_staticEntities_size } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_UserAvatar_mvc_view from "./OutSystemsUI.Content.UserAvatar.mvc$view.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$controller.js";

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
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeMenu$Action(controller.callContext(eventHandlerContext));

;
}
},
style: "cursor-auto card min-height-71vh",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
onScrollEnding: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onScrollEnding$Action(controller.callContext(eventHandlerContext));

;
},
source: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut,
style: "list list-group chat-main",
tag: "div",
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getUserName()), asPrimitiveValue(ConectaProveedoresClientVariables.getUserPhotoURL()), asPrimitiveValue(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceCommentsByInvoiceIdAggr)]
}, $if((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) >= (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length - 1))) ? (true) : (((OS$BuiltinFunctions.day(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr)) !== (OS$BuiltinFunctions.day(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdOnAttr))))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "chat-date",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center font-bold display-flex justify-content-space-between vertical-align",
visible: true,
_idProps: {
service: idService,
name: "Date"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Expression, {
style: "",
value: model.getCachedValue(idService.getId("D8JgefkwNEq7euJC0QH5EA.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr, "dddd, d \\de\\ MMMM \\de\\ yyyy");
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "7",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, function () {
return [];
}), $if((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr === OS$BuiltinFunctions.getUserId()), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-flex-end",
visible: true,
_idProps: {
service: idService,
name: "CommentLine"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("CommentsMe.Style"), function () {
return ("chat-comment justify-content-flex-end " + (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) >= (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length - 1))) ? ("") : (((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr))) ? ("margin-top-s ") : ("")))));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "CommentsMe"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-right-s display-flex flex-direction-column",
visible: true,
_idProps: {
service: idService,
name: "nameAndcommentMe"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) >= (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length - 1))) ? (true) : (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr)))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-self-flex-end",
visible: true,
_idProps: {
service: idService,
name: "name2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-size-xs",
value: model.getCachedValue(idService.getId("pKwt8UHrgk+OMrLfhX9yfg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr, "HH:mm:ss");
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "font-bold margin-left-s",
value: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
title: model.getCachedValue(idService.getId("comment2.title"), function () {
return ((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3+_HmjZec0K_KNuURXBdog#Value.-721118101.1", "shown to all")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3+_HmjZec0K_KNuURXBdog#Value.-873751424.1", "hidden from the provider")));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr;
})
},
style: model.getCachedValue(idService.getId("comment2.Style"), function () {
return ("chat-baloon sent align-self-flex-end " + ((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr) ? ("public ") : ("priv ")));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "comment2"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.messageAttr,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("photoMe.Style"), function () {
return ("flex-direction-column align-self-flex-end " + (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) <= 1)) ? ("") : (((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) - 1)).invoiceCommentAttr.createdByAttr))) ? ("") : ("splide ")))));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) - 1)).invoiceCommentAttr.createdByAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "photoMe"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, $if(((ConectaProveedoresClientVariables.getUserPhotoURL()) !== ("")), false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: ConectaProveedoresClientVariables.getUserName(),
alt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mjihat+WWEKU4l4Fy9ditQ#Value.2121520573.1", "User photo")
},
style: "avatar avatar-small border-radius-rounded",
type: /*External*/ 1,
url: ConectaProveedoresClientVariables.getUserPhotoURL(),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "UserProfile", {}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_UserAvatar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Name: ConectaProveedoresClientVariables.getUserName()
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
uuid: "19",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Comments.Style"), function () {
return ("chat-comment " + (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) >= (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length - 1))) ? ("") : (((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr))) ? ("margin-top-s ") : ("")))));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "Comments"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("photo.Style"), function () {
return ("flex-direction-column align-self-flex-end " + (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) <= 1)) ? ("") : (((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) - 1)).invoiceCommentAttr.createdByAttr))) ? ("") : ("splide ")))));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr;
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) - 1)).invoiceCommentAttr.createdByAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "photo"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, $if(((ConectaProveedoresClientVariables.getUserPhotoURL()) !== ("")), false, this, function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
title: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.usernameAttr,
alt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("i0yucOitiE62Sh4+uHlU0A#Value.2121520573.1", "User photo")
},
style: "avatar avatar-small border-radius-rounded",
type: /*External*/ 1,
url: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.photoUrlAttr,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
url_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "UserProfile", {}),
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_UserAvatar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Name: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.usernameAttr,
_nameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
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
uuid: "24",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s ",
visible: true,
_idProps: {
service: idService,
name: "nameAndcomment"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) >= (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.length - 1))) ? (true) : (((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdByAttr) !== (model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getItem((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).invoiceCommentAttr.createdByAttr)))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "name"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "font-bold",
value: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "margin-left-s font-size-xs",
value: model.getCachedValue(idService.getId("UCrsWLqFGUmqaLx9dWffJQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr, "HH:mm:ss");
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
title: model.getCachedValue(idService.getId("comment.title"), function () {
return ((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+qQ5w+uLqkyJQ4zVHGfqRw#Value.-721118101.1", "shown to all")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+qQ5w+uLqkyJQ4zVHGfqRw#Value.-873751424.1", "hidden from the provider")));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr;
})
},
style: model.getCachedValue(idService.getId("comment.Style"), function () {
return ("chat-baloon received " + ((model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr) ? ("public ") : ("priv ")));
}, function () {
return model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.isPublicAttr;
}),
visible: true,
_idProps: {
service: idService,
name: "comment"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
value: model.variables.getInvoiceCommentsByInvoiceIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceCommentAttr.messageAttr,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)
}))))];
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getUserName()), asPrimitiveValue(ConectaProveedoresClientVariables.getUserPhotoURL()), asPrimitiveValue(model.variables.getInvoiceCommentsByInvoiceIdAggr.dataFetchStatusAttr)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "chat-date chat-empty no-margin",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center font-bold display-flex justify-content-space-between vertical-align",
visible: true,
_idProps: {
service: idService,
name: "Date2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "33",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $text(getTranslation("KoKbTcIRm02crQDqMoayJQ#Value", "No messages yet.")), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "34",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "padding-base",
visible: model.getCachedValue(idService.getId("WritingBar.Visible"), function () {
return (!(ConectaProveedoresController$default.checkTelcelUserAuditorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
name: "WritingBar"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("VwZRgSOPGkCZPMdZ5dAViw.Style"), function () {
return ("chat-input " + ((model.variables.isPublicVar) ? ("public ") : ("priv ")));
}, function () {
return model.variables.isPublicVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("d4IgongEskidWZxXvElgvA#ValueExpression.-2049762883.1", "Write your comment here"),
style: "",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.newMsgVar, function (value) {
model.variables.newMsgVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_NewMsg"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Link, {
enabled: ((model.variables.newMsgVar) !== ("")),
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickSendMsg$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "send-btn",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "comment",
iconSize: /*Twotimes*/ 1,
style: model.getCachedValue(idService.getId("hjmRUbZ8dU2LN8UdC1tYew.Style"), function () {
return ("full-height margin-top-xs margin-left-xs " + ((model.variables.isPublicVar) ? ("text-secondary ") : ("text-primary ")));
}, function () {
return model.variables.isPublicVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "options-menu",
visible: model.variables.isOpenMenuVar,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex vertical-align padding-s height-50px border-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "width-40px vertical-align justify-content-center",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
style: "width: fill;"
},
style: "checkbox text-neutral-0 background-neutral-0",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.isPublicVar, function (value) {
model.variables.isPublicVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("KBY+e1S9QEyYznff0mh48Q#Value", "Share with supplier"))],
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "height-50px display-flex vertical-align padding-s",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickErase$Action(controller.callContext(eventHandlerContext));

;
},
style: "width-40px",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "eraser",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("l8ClKk+yXUWp4KaziIpuCQ#Value", "Clean message"))],
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickMenu$Action(controller.callContext(eventHandlerContext));

;
},
style: model.getCachedValue(idService.getId("+Z6AnDkt_kWwEwOUehcGQQ.Style"), function () {
return (("btn-chat " + (((!(model.variables.isOpenMenuVar))) ? ("btn-chat-closed ") : ("btn-chat-open "))) + " ");
}, function () {
return model.variables.isOpenMenuVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-dots",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "dot",
text: ["."],
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "dot",
text: ["."],
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "dot",
text: ["."],
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), $if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [$if(model.variables.isPublicVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "background-secondary input-msg italic",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Gkf6DNqtBkG4uDhG6jyutQ#Value", "the messages you send will be shared with the supplier")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "background-primary input-msg",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("W6Ox7ZnGeEqrVjX2GepIlA#Value", "the messages you send will not be shared with the supplier")))];
})];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Bottombar"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceDetailsChat",
functionKey: "802165c4-9769-4c0b-9bfc-e6588b87cd6c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Wb_InvoiceDetailsChat",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.css"];
};


ELEM.getJsDependencies = function () {
return ["scripts/ConectaProveedores.UserScripts.ChatScrollToBottom.js"];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Content_UserAvatar_mvc_view];
};


return ELEM;
};

export default componentFactory()
