namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (C8T2eHMnNUmkepq1D6qOWg)
///  <code>RC_aae113dc341165a54f51793c1371eeba</code> that represent
/// s
///  <code>CurrencyUserOrderStatusOrderMainItemOrderMainItemStatusOrderMainOrderDetailOrderApprovalLevel
/// QtdDeliveredQuantityAvailableTotalDeliveryStatusUser_Extended_InternalCompanySupplierRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CurrencyUserOrderStatusOrderMainItemOrderMainItemStatusOrderMainOrderDetailOrderApprovalLevelQtdDeliveredQuantityAvailableTotalDeliveryStatusUser_Extended_InternalCompanySupplierRecord
public partial struct RC_aae113dc341165a54f51793c1371eeba : ITypedRecord<RC_aae113dc341165a54f51793c1371eeba> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdOrderMainItemStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+fLa6m9EGbDjkIjTA77i7w");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdQtdDelivered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9Zuz+Kthq8ukQ44MjlTK2g");
internal static readonly GlobalObjectKey IdQuantityAvailable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Dyip_Y7+mr6us_rUjPhO3Q");
internal static readonly GlobalObjectKey IdTotal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KyIz5yTIHJh2KrFMN_rRjQ");
internal static readonly GlobalObjectKey IdDeliveryStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WlB7Gvi6ulm27xW_IbzRsA");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord ssENOrderMainItemStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTQtdDelivered;

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTQuantityAvailable;

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTTotal;

public STTextStructure ssSTDeliveryStatus;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_aae113dc341165a54f51793c1371eeba() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENOrderMainItemStatus = new EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssSTQtdDelivered = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
ssSTQuantityAvailable = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
ssSTTotal = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
ssSTDeliveryStatus = new STTextStructure();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[15];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(51,false);
    all[4] = new BitArray(5,false);
    all[5] = new BitArray(29,false);
    all[6] = new BitArray(39,false);
    all[7] = new BitArray(17,false);
    all[8] = null;
    all[9] = null;
    all[10] = null;
    all[11] = null;
    all[12] = new BitArray(20,false);
    all[13] = new BitArray(11,false);
    all[14] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMainItemStatus.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[12];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[13];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[14];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENOrderStatus.OptimizedAttributes = value[2];
    ssENOrderMainItem.OptimizedAttributes = value[3];
    ssENOrderMainItemStatus.OptimizedAttributes = value[4];
    ssENOrderMain.OptimizedAttributes = value[5];
    ssENOrderDetail.OptimizedAttributes = value[6];
    ssENOrderApprovalLevel.OptimizedAttributes = value[7];
    ssSTQtdDelivered.OptimizedAttributes = value[8];
    ssSTQuantityAvailable.OptimizedAttributes = value[9];
    ssSTTotal.OptimizedAttributes = value[10];
    ssSTDeliveryStatus.OptimizedAttributes = value[11];
    ssENUser_Extended_Internal.OptimizedAttributes = value[12];
    ssENCompany.OptimizedAttributes = value[13];
    ssENSupplier.OptimizedAttributes = value[14];
    }
}
get{
    BitArray[] all = new BitArray[15];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENOrderStatus.OptimizedAttributes;
    all[3] = ssENOrderMainItem.OptimizedAttributes;
    all[4] = ssENOrderMainItemStatus.OptimizedAttributes;
    all[5] = ssENOrderMain.OptimizedAttributes;
    all[6] = ssENOrderDetail.OptimizedAttributes;
    all[7] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[8] = null;
    all[9] = null;
    all[10] = null;
    all[11] = null;
    all[12] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[13] = ssENCompany.OptimizedAttributes;
    all[14] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENUser.Read( r, ref index);
ssENOrderStatus.Read( r, ref index);
ssENOrderMainItem.Read( r, ref index);
ssENOrderMainItemStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssSTQtdDelivered.Read( r, ref index);
ssSTQuantityAvailable.Read( r, ref index);
ssSTTotal.Read( r, ref index);
ssSTDeliveryStatus.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_aae113dc341165a54f51793c1371eeba r) {
this = r;
}


public static bool operator == (RC_aae113dc341165a54f51793c1371eeba a, RC_aae113dc341165a54f51793c1371eeba b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENOrderMainItemStatus != b.ssENOrderMainItemStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssSTQtdDelivered != b.ssSTQtdDelivered) return false;
if (a.ssSTQuantityAvailable != b.ssSTQuantityAvailable) return false;
if (a.ssSTTotal != b.ssSTTotal) return false;
if (a.ssSTDeliveryStatus != b.ssSTDeliveryStatus) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_aae113dc341165a54f51793c1371eeba a, RC_aae113dc341165a54f51793c1371eeba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aae113dc341165a54f51793c1371eeba)) return false;
return (this == (RC_aae113dc341165a54f51793c1371eeba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENOrderMainItemStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssSTQtdDelivered.GetHashCode()
 ^ ssSTQuantityAvailable.GetHashCode()
 ^ ssSTTotal.GetHashCode()
 ^ ssSTDeliveryStatus.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
ssENOrderMainItemStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssSTQtdDelivered.RecursiveReset();
ssSTQuantityAvailable.RecursiveReset();
ssSTTotal.RecursiveReset();
ssSTDeliveryStatus.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
ssENOrderMainItemStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssSTQtdDelivered.InternalRecursiveSave();
ssSTQuantityAvailable.InternalRecursiveSave();
ssSTTotal.InternalRecursiveSave();
ssSTDeliveryStatus.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_aae113dc341165a54f51793c1371eeba Duplicate() {
RC_aae113dc341165a54f51793c1371eeba t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENOrderMainItemStatus = (EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord)this.ssENOrderMainItemStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssSTQtdDelivered = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTQtdDelivered.Duplicate();
t.ssSTQuantityAvailable = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTQuantityAvailable.Duplicate();
t.ssSTTotal = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTTotal.Duplicate();
t.ssSTDeliveryStatus = (STTextStructure)this.ssSTDeliveryStatus.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "ordermainitemstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemStatus")) variable.Value = ssENOrderMainItemStatus; else variable.Optimized = true;
variable.SetFieldName("ordermainitemstatus");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "qtddelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QtdDelivered")) variable.Value = ssSTQtdDelivered; else variable.Optimized = true;
variable.SetFieldName("qtddelivered");
} else if (head == "quantityavailable") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantityAvailable")) variable.Value = ssSTQuantityAvailable; else variable.Optimized = true;
variable.SetFieldName("quantityavailable");
} else if (head == "total") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Total")) variable.Value = ssSTTotal; else variable.Optimized = true;
variable.SetFieldName("total");
} else if (head == "deliverystatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryStatus")) variable.Value = ssSTDeliveryStatus; else variable.Optimized = true;
variable.SetFieldName("deliverystatus");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdUser) {
return ssENUser;
}
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdOrderMainItemStatus) {
return ssENOrderMainItemStatus;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdQtdDelivered) {
return ssSTQtdDelivered;
}
if (key == IdQuantityAvailable) {
return ssSTQuantityAvailable;
}
if (key == IdTotal) {
return ssSTTotal;
}
if (key == IdDeliveryStatus) {
return ssSTDeliveryStatus;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdOrderMainItemStatus.Key.AsGuid) {
return ssENOrderMainItemStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdQtdDelivered.Key.AsGuid) {
return ssSTQtdDelivered;
}
if (attributeKey == IdQuantityAvailable.Key.AsGuid) {
return ssSTQuantityAvailable;
}
if (attributeKey == IdTotal.Key.AsGuid) {
return ssSTTotal;
}
if (attributeKey == IdDeliveryStatus.Key.AsGuid) {
return ssSTDeliveryStatus;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENOrderMainItemStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItemStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssSTQtdDelivered.FillFromOther((IRecord) other.AttributeGet(IdQtdDelivered));
ssSTQuantityAvailable.FillFromOther((IRecord) other.AttributeGet(IdQuantityAvailable));
ssSTTotal.FillFromOther((IRecord) other.AttributeGet(IdTotal));
ssSTDeliveryStatus.FillFromOther((IRecord) other.AttributeGet(IdDeliveryStatus));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_aae113dc341165a54f51793c1371eeba
/// <summary>
/// RecordList type
///  <code>CurrencyUserOrderStatusOrderMainItemOrderMainItemStatusOrderMainOrderDetailOrderApprovalLevel
/// QtdDeliveredQuantityAvailableTotalDeliveryStatusUser_Extended_InternalCompanySupplierRecordList</cod
/// e> that represents a record list of <code>Currency, User, OrderStatus, OrderMainItem,
///  OrderMainItemStatus, OrderMain, OrderDetail, OrderApprovalLevel, Decimal, Decimal, Decimal, Text2
/// , User_Extended_Internal, Company, Supplier</code>
/// </summary>
public partial class RL_f5a2fdd028de7dc3b32fee45ae563140 : GenericRecordList<RC_aae113dc341165a54f51793c1371eeba>, IEnumerable, IEnumerator {

protected override RC_aae113dc341165a54f51793c1371eeba GetElementDefaultValue() {
return new RC_aae113dc341165a54f51793c1371eeba();
}

public T[] ToArray<T>(Func<RC_aae113dc341165a54f51793c1371eeba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5a2fdd028de7dc3b32fee45ae563140 recordList, Func<RC_aae113dc341165a54f51793c1371eeba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5a2fdd028de7dc3b32fee45ae563140(RC_aae113dc341165a54f51793c1371eeba[] array) {
  RL_f5a2fdd028de7dc3b32fee45ae563140 result = new RL_f5a2fdd028de7dc3b32fee45ae563140();
result.InnerFromArray(array);
    return result;
}

public static RL_f5a2fdd028de7dc3b32fee45ae563140 ToList<T>(T[] array, Func <T, RC_aae113dc341165a54f51793c1371eeba> converter) {
  RL_f5a2fdd028de7dc3b32fee45ae563140 result = new RL_f5a2fdd028de7dc3b32fee45ae563140();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5a2fdd028de7dc3b32fee45ae563140 FromRestList<T>(RestList<T> restList, Func <T, RC_aae113dc341165a54f51793c1371eeba> converter) {
  RL_f5a2fdd028de7dc3b32fee45ae563140 result = new RL_f5a2fdd028de7dc3b32fee45ae563140();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5a2fdd028de7dc3b32fee45ae563140() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[15];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(51,false);
def[4] = new BitArray(5,false);
def[5] = new BitArray(29,false);
def[6] = new BitArray(39,false);
def[7] = new BitArray(17,false);
def[8] = null;
def[9] = null;
def[10] = null;
def[11] = null;
def[12] = new BitArray(20,false);
def[13] = new BitArray(11,false);
def[14] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_aae113dc341165a54f51793c1371eeba> NewList() {
return new RL_f5a2fdd028de7dc3b32fee45ae563140();
}


} // RL_f5a2fdd028de7dc3b32fee45ae563140
}

