namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TJgF5M8fVkmvuvYxT_MkbA)
///  <code>RC_febdfe749051cd5849a077ecffdddeec</code> that represent
/// s <code>UserInvoiceInvoiceLogRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceLogRecord
public partial struct RC_febdfe749051cd5849a077ecffdddeec : ITypedRecord<RC_febdfe749051cd5849a077ecffdddeec> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lYav3juTveGVyKSHxd8NxA");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord ssENInvoiceLog;


public BitArray OptimizedAttributes;

public RC_febdfe749051cd5849a077ecffdddeec() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceLog = new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceLog.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceLog.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceLog.OptimizedAttributes;
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
public void ReadIM(RC_febdfe749051cd5849a077ecffdddeec r) {
this = r;
}


public static bool operator == (RC_febdfe749051cd5849a077ecffdddeec a, RC_febdfe749051cd5849a077ecffdddeec b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceLog != b.ssENInvoiceLog) return false;
return true;
}

public static bool operator != (RC_febdfe749051cd5849a077ecffdddeec a, RC_febdfe749051cd5849a077ecffdddeec b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_febdfe749051cd5849a077ecffdddeec)) return false;
return (this == (RC_febdfe749051cd5849a077ecffdddeec)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceLog.InternalRecursiveSave();
}


public RC_febdfe749051cd5849a077ecffdddeec Duplicate() {
RC_febdfe749051cd5849a077ecffdddeec t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceLog = (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord)this.ssENInvoiceLog.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceLog.FillFromOther((IRecord) other.AttributeGet(IdInvoiceLog));
}
} // RC_febdfe749051cd5849a077ecffdddeec
/// <summary>
/// RecordList type <code>UserInvoiceInvoiceLogRecordList</code> that represents a record list of
///  <code>User, Invoice, InvoiceLog</code>
/// </summary>
public partial class RL_8623462923ce4f5fca06be3fb804a6be : GenericRecordList<RC_febdfe749051cd5849a077ecffdddeec>, IEnumerable, IEnumerator {

protected override RC_febdfe749051cd5849a077ecffdddeec GetElementDefaultValue() {
return new RC_febdfe749051cd5849a077ecffdddeec();
}

public T[] ToArray<T>(Func<RC_febdfe749051cd5849a077ecffdddeec, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8623462923ce4f5fca06be3fb804a6be recordList, Func<RC_febdfe749051cd5849a077ecffdddeec, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8623462923ce4f5fca06be3fb804a6be(RC_febdfe749051cd5849a077ecffdddeec[] array) {
  RL_8623462923ce4f5fca06be3fb804a6be result = new RL_8623462923ce4f5fca06be3fb804a6be();
result.InnerFromArray(array);
    return result;
}

public static RL_8623462923ce4f5fca06be3fb804a6be ToList<T>(T[] array, Func <T, RC_febdfe749051cd5849a077ecffdddeec> converter) {
  RL_8623462923ce4f5fca06be3fb804a6be result = new RL_8623462923ce4f5fca06be3fb804a6be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8623462923ce4f5fca06be3fb804a6be FromRestList<T>(RestList<T> restList, Func <T, RC_febdfe749051cd5849a077ecffdddeec> converter) {
  RL_8623462923ce4f5fca06be3fb804a6be result = new RL_8623462923ce4f5fca06be3fb804a6be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8623462923ce4f5fca06be3fb804a6be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_febdfe749051cd5849a077ecffdddeec> NewList() {
return new RL_8623462923ce4f5fca06be3fb804a6be();
}


} // RL_8623462923ce4f5fca06be3fb804a6be
}

