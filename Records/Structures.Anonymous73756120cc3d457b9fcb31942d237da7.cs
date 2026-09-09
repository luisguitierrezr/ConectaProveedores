namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IGF1cz3Me0WfyzGULSN9pw)
///  <code>RC_96ee18663de42b81d96c758873824c1f</code> that represent
/// s
///  <code>CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigment
/// CompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigmentCompanySupplierRegionRecord
public partial struct RC_96ee18663de42b81d96c758873824c1f : ITypedRecord<RC_96ee18663de42b81d96c758873824c1f> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdDaysWithoutAssigment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*exfQ7v3ASi8BdmZbDWefDg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public bool ssIsSelected;

public int ssDaysWithoutAssigment;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_96ee18663de42b81d96c758873824c1f() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssIsSelected = false;
ssDaysWithoutAssigment = 0;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(8,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(17,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(28,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENOrderStatus.OptimizedAttributes = value[2];
    ssENOrderApproval.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENOrderApprovalLevel.OptimizedAttributes = value[5];
    ssENCompany.OptimizedAttributes = value[6];
    ssENSupplier.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENOrderStatus.OptimizedAttributes;
    all[3] = ssENOrderApproval.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[6] = ssENCompany.OptimizedAttributes;
    all[7] = ssENSupplier.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
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
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigmentCompanySupplierRegionRecord.IsSelected", false);
ssDaysWithoutAssigment = r.ReadInteger(index++, "CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigmentCompanySupplierRegionRecord.DaysWithoutAssigment", 0);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_96ee18663de42b81d96c758873824c1f r) {
this = r;
}


public static bool operator == (RC_96ee18663de42b81d96c758873824c1f a, RC_96ee18663de42b81d96c758873824c1f b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssDaysWithoutAssigment != b.ssDaysWithoutAssigment) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_96ee18663de42b81d96c758873824c1f a, RC_96ee18663de42b81d96c758873824c1f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_96ee18663de42b81d96c758873824c1f)) return false;
return (this == (RC_96ee18663de42b81d96c758873824c1f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssDaysWithoutAssigment.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_96ee18663de42b81d96c758873824c1f Duplicate() {
RC_96ee18663de42b81d96c758873824c1f t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssIsSelected = this.ssIsSelected;
t.ssDaysWithoutAssigment = this.ssDaysWithoutAssigment;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
} else if (head == "dayswithoutassigment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DaysWithoutAssigment")) variable.Value = ssDaysWithoutAssigment; else variable.Optimized = true;
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdDaysWithoutAssigment) {
return ssDaysWithoutAssigment;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdDaysWithoutAssigment.Key.AsGuid) {
return ssDaysWithoutAssigment;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssDaysWithoutAssigment = (int) other.AttributeGet(IdDaysWithoutAssigment);
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_96ee18663de42b81d96c758873824c1f
/// <summary>
/// RecordList type
///  <code>CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigment
/// CompanySupplierRegionRecordList</code> that represents a record list of <code>Currency, User,
///  OrderStatus, OrderApproval, OrderMain, OrderApprovalLevel, Boolean, Integer, Company, Supplier
/// , Region</code>
/// </summary>
public partial class RL_ae89b43259faf914dcb9547c573c4cd7 : GenericRecordList<RC_96ee18663de42b81d96c758873824c1f>, IEnumerable, IEnumerator {

protected override RC_96ee18663de42b81d96c758873824c1f GetElementDefaultValue() {
return new RC_96ee18663de42b81d96c758873824c1f();
}

public T[] ToArray<T>(Func<RC_96ee18663de42b81d96c758873824c1f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae89b43259faf914dcb9547c573c4cd7 recordList, Func<RC_96ee18663de42b81d96c758873824c1f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae89b43259faf914dcb9547c573c4cd7(RC_96ee18663de42b81d96c758873824c1f[] array) {
  RL_ae89b43259faf914dcb9547c573c4cd7 result = new RL_ae89b43259faf914dcb9547c573c4cd7();
result.InnerFromArray(array);
    return result;
}

public static RL_ae89b43259faf914dcb9547c573c4cd7 ToList<T>(T[] array, Func <T, RC_96ee18663de42b81d96c758873824c1f> converter) {
  RL_ae89b43259faf914dcb9547c573c4cd7 result = new RL_ae89b43259faf914dcb9547c573c4cd7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae89b43259faf914dcb9547c573c4cd7 FromRestList<T>(RestList<T> restList, Func <T, RC_96ee18663de42b81d96c758873824c1f> converter) {
  RL_ae89b43259faf914dcb9547c573c4cd7 result = new RL_ae89b43259faf914dcb9547c573c4cd7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae89b43259faf914dcb9547c573c4cd7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(8,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(17,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(28,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_96ee18663de42b81d96c758873824c1f> NewList() {
return new RL_ae89b43259faf914dcb9547c573c4cd7();
}


} // RL_ae89b43259faf914dcb9547c573c4cd7
}

