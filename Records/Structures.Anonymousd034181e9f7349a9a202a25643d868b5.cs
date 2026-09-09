namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Hhg00HOfqUmiAqJWQ9hotQ)
///  <code>RC_deaf8695933be1bd95c8a487c5df0dc4</code> that represents <code>InvoiceLogRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceLogRecord
public partial struct RC_deaf8695933be1bd95c8a487c5df0dc4 : ITypedRecord<RC_deaf8695933be1bd95c8a487c5df0dc4> {
internal static readonly GlobalObjectKey IdInvoiceLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lYav3juTveGVyKSHxd8NxA");

public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord ssENInvoiceLog;


public static implicit operator EN_bf34270fdd0f7785895f41a998e724e8EntityRecord( RC_deaf8695933be1bd95c8a487c5df0dc4 r) {
return r.ssENInvoiceLog;
}

public static implicit operator RC_deaf8695933be1bd95c8a487c5df0dc4 (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord r) {
RC_deaf8695933be1bd95c8a487c5df0dc4 res = new RC_deaf8695933be1bd95c8a487c5df0dc4 ();
res.ssENInvoiceLog = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceLog.ChangedAttributes = value;
}
get {
    return ssENInvoiceLog.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_deaf8695933be1bd95c8a487c5df0dc4() {
OptimizedAttributes = null;
ssENInvoiceLog = new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceLog.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceLog.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceLog.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_deaf8695933be1bd95c8a487c5df0dc4 r) {
this = r;
}


public static bool operator == (RC_deaf8695933be1bd95c8a487c5df0dc4 a, RC_deaf8695933be1bd95c8a487c5df0dc4 b) {
if (a.ssENInvoiceLog != b.ssENInvoiceLog) return false;
return true;
}

public static bool operator != (RC_deaf8695933be1bd95c8a487c5df0dc4 a, RC_deaf8695933be1bd95c8a487c5df0dc4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_deaf8695933be1bd95c8a487c5df0dc4)) return false;
return (this == (RC_deaf8695933be1bd95c8a487c5df0dc4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceLog.InternalRecursiveSave();
}


public RC_deaf8695933be1bd95c8a487c5df0dc4 Duplicate() {
RC_deaf8695933be1bd95c8a487c5df0dc4 t;
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
if (head == "invoicelog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceLog")) variable.Value = ssENInvoiceLog; else variable.Optimized = true;
variable.SetFieldName("invoicelog");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceLog.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceLog.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceLog) {
return ssENInvoiceLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceLog.Key.AsGuid) {
return ssENInvoiceLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceLog.FillFromOther((IRecord) other.AttributeGet(IdInvoiceLog));
}
} // RC_deaf8695933be1bd95c8a487c5df0dc4
/// <summary>
/// RecordList type <code>InvoiceLogRecordList</code> that represents a record list of
///  <code>InvoiceLog</code>
/// </summary>
public partial class RL_741430f005c8952521bfb8de73240573 : GenericRecordList<RC_deaf8695933be1bd95c8a487c5df0dc4>, IEnumerable, IEnumerator {

protected override RC_deaf8695933be1bd95c8a487c5df0dc4 GetElementDefaultValue() {
return new RC_deaf8695933be1bd95c8a487c5df0dc4();
}

public T[] ToArray<T>(Func<RC_deaf8695933be1bd95c8a487c5df0dc4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_741430f005c8952521bfb8de73240573 recordList, Func<RC_deaf8695933be1bd95c8a487c5df0dc4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_741430f005c8952521bfb8de73240573(RC_deaf8695933be1bd95c8a487c5df0dc4[] array) {
  RL_741430f005c8952521bfb8de73240573 result = new RL_741430f005c8952521bfb8de73240573();
result.InnerFromArray(array);
    return result;
}

public static RL_741430f005c8952521bfb8de73240573 ToList<T>(T[] array, Func <T, RC_deaf8695933be1bd95c8a487c5df0dc4> converter) {
  RL_741430f005c8952521bfb8de73240573 result = new RL_741430f005c8952521bfb8de73240573();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_741430f005c8952521bfb8de73240573 FromRestList<T>(RestList<T> restList, Func <T, RC_deaf8695933be1bd95c8a487c5df0dc4> converter) {
  RL_741430f005c8952521bfb8de73240573 result = new RL_741430f005c8952521bfb8de73240573();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_741430f005c8952521bfb8de73240573() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_deaf8695933be1bd95c8a487c5df0dc4> NewList() {
return new RL_741430f005c8952521bfb8de73240573();
}


} // RL_741430f005c8952521bfb8de73240573
}

