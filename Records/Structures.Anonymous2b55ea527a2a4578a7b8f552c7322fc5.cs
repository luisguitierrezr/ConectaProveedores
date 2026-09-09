namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UupVKyp6eEWnuPVSxzIvxQ)
///  <code>RC_e278706027049cb67d7e751f6d362f51</code> that represent
/// s
///  <code>CurrencyFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelOrderMainShowActionsRecord</cod
/// e> <p>Description: </p>
/// </summary>
// Name: CurrencyFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelOrderMainShowActionsRecord
public partial struct RC_e278706027049cb67d7e751f6d362f51 : ITypedRecord<RC_e278706027049cb67d7e751f6d362f51> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdShowActions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iGmpvm3VJj82cP9YIJa4yw");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public bool ssShowActions;


public BitArray OptimizedAttributes;

public RC_e278706027049cb67d7e751f6d362f51() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssShowActions = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(24,false);
    all[4] = new BitArray(20,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENFolioStatus.OptimizedAttributes = value[1];
    ssENFolioApproval.OptimizedAttributes = value[2];
    ssENInvoice.OptimizedAttributes = value[3];
    ssENFolio.OptimizedAttributes = value[4];
    ssENFolioApprovalLevel.OptimizedAttributes = value[5];
    ssENOrderMain.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENFolioStatus.OptimizedAttributes;
    all[2] = ssENFolioApproval.OptimizedAttributes;
    all[3] = ssENInvoice.OptimizedAttributes;
    all[4] = ssENFolio.OptimizedAttributes;
    all[5] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[6] = ssENOrderMain.OptimizedAttributes;
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
ssENFolioStatus.Read( r, ref index);
ssENFolioApproval.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssShowActions = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelOrderMainShowActionsRecord.ShowActions", false);
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
public void ReadIM(RC_e278706027049cb67d7e751f6d362f51 r) {
this = r;
}


public static bool operator == (RC_e278706027049cb67d7e751f6d362f51 a, RC_e278706027049cb67d7e751f6d362f51 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssShowActions != b.ssShowActions) return false;
return true;
}

public static bool operator != (RC_e278706027049cb67d7e751f6d362f51 a, RC_e278706027049cb67d7e751f6d362f51 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e278706027049cb67d7e751f6d362f51)) return false;
return (this == (RC_e278706027049cb67d7e751f6d362f51)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssShowActions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENFolioStatus.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENFolioStatus.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_e278706027049cb67d7e751f6d362f51 Duplicate() {
RC_e278706027049cb67d7e751f6d362f51 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssShowActions = this.ssShowActions;
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
} else if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
} else if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "showactions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowActions")) variable.Value = ssShowActions; else variable.Optimized = true;
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
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdShowActions) {
return ssShowActions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdShowActions.Key.AsGuid) {
return ssShowActions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssShowActions = (bool) other.AttributeGet(IdShowActions);
}
} // RC_e278706027049cb67d7e751f6d362f51
/// <summary>
/// RecordList type
///  <code>CurrencyFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelOrderMainShowActionsRecordList<
/// /code> that represents a record list of <code>Currency, FolioStatus, FolioApproval, Invoice, Folio,
///  FolioApprovalLevel, OrderMain, Boolean</code>
/// </summary>
public partial class RL_eed3c87ea3369e022265db9ef075a8c7 : GenericRecordList<RC_e278706027049cb67d7e751f6d362f51>, IEnumerable, IEnumerator {

protected override RC_e278706027049cb67d7e751f6d362f51 GetElementDefaultValue() {
return new RC_e278706027049cb67d7e751f6d362f51();
}

public T[] ToArray<T>(Func<RC_e278706027049cb67d7e751f6d362f51, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eed3c87ea3369e022265db9ef075a8c7 recordList, Func<RC_e278706027049cb67d7e751f6d362f51, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eed3c87ea3369e022265db9ef075a8c7(RC_e278706027049cb67d7e751f6d362f51[] array) {
  RL_eed3c87ea3369e022265db9ef075a8c7 result = new RL_eed3c87ea3369e022265db9ef075a8c7();
result.InnerFromArray(array);
    return result;
}

public static RL_eed3c87ea3369e022265db9ef075a8c7 ToList<T>(T[] array, Func <T, RC_e278706027049cb67d7e751f6d362f51> converter) {
  RL_eed3c87ea3369e022265db9ef075a8c7 result = new RL_eed3c87ea3369e022265db9ef075a8c7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eed3c87ea3369e022265db9ef075a8c7 FromRestList<T>(RestList<T> restList, Func <T, RC_e278706027049cb67d7e751f6d362f51> converter) {
  RL_eed3c87ea3369e022265db9ef075a8c7 result = new RL_eed3c87ea3369e022265db9ef075a8c7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eed3c87ea3369e022265db9ef075a8c7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(24,false);
def[4] = new BitArray(20,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e278706027049cb67d7e751f6d362f51> NewList() {
return new RL_eed3c87ea3369e022265db9ef075a8c7();
}


} // RL_eed3c87ea3369e022265db9ef075a8c7
}

