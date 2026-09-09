namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lbO7FVuVeEykzGxxVpy3Xw)
///  <code>RC_0971e035ffe4575db2572522684e7dc7</code> that represent
/// s <code>UserInvoiceInvoiceLogRequisitionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceLogRequisitionRecord
public partial struct RC_0971e035ffe4575db2572522684e7dc7 : ITypedRecord<RC_0971e035ffe4575db2572522684e7dc7> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lYav3juTveGVyKSHxd8NxA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord ssENInvoiceLog;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;


public BitArray OptimizedAttributes;

public RC_0971e035ffe4575db2572522684e7dc7() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceLog = new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceLog.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceLog.OptimizedAttributes = value[2];
    ssENRequisition.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceLog.OptimizedAttributes;
    all[3] = ssENRequisition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceLog.Read( r, ref index);
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_0971e035ffe4575db2572522684e7dc7 r) {
this = r;
}


public static bool operator == (RC_0971e035ffe4575db2572522684e7dc7 a, RC_0971e035ffe4575db2572522684e7dc7 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceLog != b.ssENInvoiceLog) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
return true;
}

public static bool operator != (RC_0971e035ffe4575db2572522684e7dc7 a, RC_0971e035ffe4575db2572522684e7dc7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0971e035ffe4575db2572522684e7dc7)) return false;
return (this == (RC_0971e035ffe4575db2572522684e7dc7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceLog.GetHashCode()
 ^ ssENRequisition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceLog.RecursiveReset();
ssENRequisition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceLog.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
}


public RC_0971e035ffe4575db2572522684e7dc7 Duplicate() {
RC_0971e035ffe4575db2572522684e7dc7 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceLog = (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord)this.ssENInvoiceLog.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicelog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceLog")) variable.Value = ssENInvoiceLog; else variable.Optimized = true;
variable.SetFieldName("invoicelog");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceLog) {
return ssENInvoiceLog;
}
if (key == IdRequisition) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceLog.Key.AsGuid) {
return ssENInvoiceLog;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceLog.FillFromOther((IRecord) other.AttributeGet(IdInvoiceLog));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
}
} // RC_0971e035ffe4575db2572522684e7dc7
/// <summary>
/// RecordList type <code>UserInvoiceInvoiceLogRequisitionRecordList</code> that represents a record
///  list of <code>User, Invoice, InvoiceLog, Requisition</code>
/// </summary>
public partial class RL_525e91487e9beaec206458508c26b294 : GenericRecordList<RC_0971e035ffe4575db2572522684e7dc7>, IEnumerable, IEnumerator {

protected override RC_0971e035ffe4575db2572522684e7dc7 GetElementDefaultValue() {
return new RC_0971e035ffe4575db2572522684e7dc7();
}

public T[] ToArray<T>(Func<RC_0971e035ffe4575db2572522684e7dc7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_525e91487e9beaec206458508c26b294 recordList, Func<RC_0971e035ffe4575db2572522684e7dc7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_525e91487e9beaec206458508c26b294(RC_0971e035ffe4575db2572522684e7dc7[] array) {
  RL_525e91487e9beaec206458508c26b294 result = new RL_525e91487e9beaec206458508c26b294();
result.InnerFromArray(array);
    return result;
}

public static RL_525e91487e9beaec206458508c26b294 ToList<T>(T[] array, Func <T, RC_0971e035ffe4575db2572522684e7dc7> converter) {
  RL_525e91487e9beaec206458508c26b294 result = new RL_525e91487e9beaec206458508c26b294();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_525e91487e9beaec206458508c26b294 FromRestList<T>(RestList<T> restList, Func <T, RC_0971e035ffe4575db2572522684e7dc7> converter) {
  RL_525e91487e9beaec206458508c26b294 result = new RL_525e91487e9beaec206458508c26b294();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_525e91487e9beaec206458508c26b294() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0971e035ffe4575db2572522684e7dc7> NewList() {
return new RL_525e91487e9beaec206458508c26b294();
}


} // RL_525e91487e9beaec206458508c26b294
}

