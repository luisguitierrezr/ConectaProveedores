namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (V+7njwtCI0a0nKVC7pGfAA)
///  <code>RC_3c4405ea19e4fb66009c54078ab80e28</code> that represent
/// s
///  <code>User_CreatedByUser_UpdatedByFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelRecord</cod
/// e> <p>Description: </p>
/// </summary>
// Name: User_CreatedByUser_UpdatedByFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelRecord
public partial struct RC_3c4405ea19e4fb66009c54078ab80e28 : ITypedRecord<RC_3c4405ea19e4fb66009c54078ab80e28> {
internal static readonly GlobalObjectKey IdUser_CreatedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Oz+YqADw5Hde7dfemVySZA");
internal static readonly GlobalObjectKey IdUser_UpdatedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WZNnUKKhENodXZxz_YXBVg");
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public ENUserEntityRecord ssENUser_CreatedBy;

public ENUserEntityRecord ssENUser_UpdatedBy;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_3c4405ea19e4fb66009c54078ab80e28() {
OptimizedAttributes = null;
ssENUser_CreatedBy = new ENUserEntityRecord();
ssENUser_UpdatedBy = new ENUserEntityRecord();
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(24,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_CreatedBy.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_UpdatedBy.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENUser_CreatedBy.OptimizedAttributes = value[0];
    ssENUser_UpdatedBy.OptimizedAttributes = value[1];
    ssENFolioStatus.OptimizedAttributes = value[2];
    ssENFolioApproval.OptimizedAttributes = value[3];
    ssENInvoice.OptimizedAttributes = value[4];
    ssENFolio.OptimizedAttributes = value[5];
    ssENFolioApprovalLevel.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENUser_CreatedBy.OptimizedAttributes;
    all[1] = ssENUser_UpdatedBy.OptimizedAttributes;
    all[2] = ssENFolioStatus.OptimizedAttributes;
    all[3] = ssENFolioApproval.OptimizedAttributes;
    all[4] = ssENInvoice.OptimizedAttributes;
    all[5] = ssENFolio.OptimizedAttributes;
    all[6] = ssENFolioApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_CreatedBy.Read( r, ref index);
ssENUser_UpdatedBy.Read( r, ref index);
ssENFolioStatus.Read( r, ref index);
ssENFolioApproval.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_3c4405ea19e4fb66009c54078ab80e28 r) {
this = r;
}


public static bool operator == (RC_3c4405ea19e4fb66009c54078ab80e28 a, RC_3c4405ea19e4fb66009c54078ab80e28 b) {
if (a.ssENUser_CreatedBy != b.ssENUser_CreatedBy) return false;
if (a.ssENUser_UpdatedBy != b.ssENUser_UpdatedBy) return false;
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_3c4405ea19e4fb66009c54078ab80e28 a, RC_3c4405ea19e4fb66009c54078ab80e28 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3c4405ea19e4fb66009c54078ab80e28)) return false;
return (this == (RC_3c4405ea19e4fb66009c54078ab80e28)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_CreatedBy.GetHashCode()
 ^ ssENUser_UpdatedBy.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_CreatedBy.RecursiveReset();
ssENUser_UpdatedBy.RecursiveReset();
ssENFolioStatus.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_CreatedBy.InternalRecursiveSave();
ssENUser_UpdatedBy.InternalRecursiveSave();
ssENFolioStatus.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_3c4405ea19e4fb66009c54078ab80e28 Duplicate() {
RC_3c4405ea19e4fb66009c54078ab80e28 t;
t.ssENUser_CreatedBy = (ENUserEntityRecord)this.ssENUser_CreatedBy.Duplicate();
t.ssENUser_UpdatedBy = (ENUserEntityRecord)this.ssENUser_UpdatedBy.Duplicate();
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
if (head == "user_createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_CreatedBy")) variable.Value = ssENUser_CreatedBy; else variable.Optimized = true;
variable.SetFieldName("user_createdby");
} else if (head == "user_updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_UpdatedBy")) variable.Value = ssENUser_UpdatedBy; else variable.Optimized = true;
variable.SetFieldName("user_updatedby");
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
if (key == IdUser_CreatedBy) {
return ssENUser_CreatedBy;
}
if (key == IdUser_UpdatedBy) {
return ssENUser_UpdatedBy;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_CreatedBy.Key.AsGuid) {
return ssENUser_CreatedBy;
}
if (attributeKey == IdUser_UpdatedBy.Key.AsGuid) {
return ssENUser_UpdatedBy;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_CreatedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_CreatedBy));
ssENUser_UpdatedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_UpdatedBy));
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_3c4405ea19e4fb66009c54078ab80e28
/// <summary>
/// RecordList type
///  <code>User_CreatedByUser_UpdatedByFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelRecordList<
/// /code> that represents a record list of <code>User, User, FolioStatus, FolioApproval, Invoice,
///  Folio, FolioApprovalLevel</code>
/// </summary>
public partial class RL_906cfbdbf8c03778600b870bd5d6309b : GenericRecordList<RC_3c4405ea19e4fb66009c54078ab80e28>, IEnumerable, IEnumerator {

protected override RC_3c4405ea19e4fb66009c54078ab80e28 GetElementDefaultValue() {
return new RC_3c4405ea19e4fb66009c54078ab80e28();
}

public T[] ToArray<T>(Func<RC_3c4405ea19e4fb66009c54078ab80e28, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_906cfbdbf8c03778600b870bd5d6309b recordList, Func<RC_3c4405ea19e4fb66009c54078ab80e28, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_906cfbdbf8c03778600b870bd5d6309b(RC_3c4405ea19e4fb66009c54078ab80e28[] array) {
  RL_906cfbdbf8c03778600b870bd5d6309b result = new RL_906cfbdbf8c03778600b870bd5d6309b();
result.InnerFromArray(array);
    return result;
}

public static RL_906cfbdbf8c03778600b870bd5d6309b ToList<T>(T[] array, Func <T, RC_3c4405ea19e4fb66009c54078ab80e28> converter) {
  RL_906cfbdbf8c03778600b870bd5d6309b result = new RL_906cfbdbf8c03778600b870bd5d6309b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_906cfbdbf8c03778600b870bd5d6309b FromRestList<T>(RestList<T> restList, Func <T, RC_3c4405ea19e4fb66009c54078ab80e28> converter) {
  RL_906cfbdbf8c03778600b870bd5d6309b result = new RL_906cfbdbf8c03778600b870bd5d6309b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_906cfbdbf8c03778600b870bd5d6309b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(24,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3c4405ea19e4fb66009c54078ab80e28> NewList() {
return new RL_906cfbdbf8c03778600b870bd5d6309b();
}


} // RL_906cfbdbf8c03778600b870bd5d6309b
}

