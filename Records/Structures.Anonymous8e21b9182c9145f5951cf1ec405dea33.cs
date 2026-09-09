namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GLkhjpEs9UWVHPHsQF3qMw)
///  <code>RC_404aa878a81887880a35de683904d643</code> that represents <code>LogsAccountingRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LogsAccountingRecord
public partial struct RC_404aa878a81887880a35de683904d643 : ITypedRecord<RC_404aa878a81887880a35de683904d643> {
internal static readonly GlobalObjectKey IdLogsAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eKhKQBioiIcKNd5oOQTWQw");

public EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord ssENLogsAccounting;


public static implicit operator EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord( RC_404aa878a81887880a35de683904d643 r) {
return r.ssENLogsAccounting;
}

public static implicit operator RC_404aa878a81887880a35de683904d643 (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord r) {
RC_404aa878a81887880a35de683904d643 res = new RC_404aa878a81887880a35de683904d643 ();
res.ssENLogsAccounting = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENLogsAccounting.ChangedAttributes = value;
}
get {
    return ssENLogsAccounting.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_404aa878a81887880a35de683904d643() {
OptimizedAttributes = null;
ssENLogsAccounting = new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLogsAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENLogsAccounting.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENLogsAccounting.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLogsAccounting.Read( r, ref index);
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
public void ReadIM(RC_404aa878a81887880a35de683904d643 r) {
this = r;
}


public static bool operator == (RC_404aa878a81887880a35de683904d643 a, RC_404aa878a81887880a35de683904d643 b) {
if (a.ssENLogsAccounting != b.ssENLogsAccounting) return false;
return true;
}

public static bool operator != (RC_404aa878a81887880a35de683904d643 a, RC_404aa878a81887880a35de683904d643 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_404aa878a81887880a35de683904d643)) return false;
return (this == (RC_404aa878a81887880a35de683904d643)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLogsAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLogsAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLogsAccounting.InternalRecursiveSave();
}


public RC_404aa878a81887880a35de683904d643 Duplicate() {
RC_404aa878a81887880a35de683904d643 t;
t.ssENLogsAccounting = (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord)this.ssENLogsAccounting.Duplicate();
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
if (head == "logsaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LogsAccounting")) variable.Value = ssENLogsAccounting; else variable.Optimized = true;
variable.SetFieldName("logsaccounting");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENLogsAccounting.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENLogsAccounting.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLogsAccounting) {
return ssENLogsAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLogsAccounting.Key.AsGuid) {
return ssENLogsAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENLogsAccounting.FillFromOther((IRecord) other.AttributeGet(IdLogsAccounting));
}
} // RC_404aa878a81887880a35de683904d643
/// <summary>
/// RecordList type <code>LogsAccountingRecordList</code> that represents a record list of
///  <code>LogsAccounting</code>
/// </summary>
public partial class RL_cc0d70d0b18881d11cf5321352207bb5 : GenericRecordList<RC_404aa878a81887880a35de683904d643>, IEnumerable, IEnumerator {

protected override RC_404aa878a81887880a35de683904d643 GetElementDefaultValue() {
return new RC_404aa878a81887880a35de683904d643();
}

public T[] ToArray<T>(Func<RC_404aa878a81887880a35de683904d643, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc0d70d0b18881d11cf5321352207bb5 recordList, Func<RC_404aa878a81887880a35de683904d643, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc0d70d0b18881d11cf5321352207bb5(RC_404aa878a81887880a35de683904d643[] array) {
  RL_cc0d70d0b18881d11cf5321352207bb5 result = new RL_cc0d70d0b18881d11cf5321352207bb5();
result.InnerFromArray(array);
    return result;
}

public static RL_cc0d70d0b18881d11cf5321352207bb5 ToList<T>(T[] array, Func <T, RC_404aa878a81887880a35de683904d643> converter) {
  RL_cc0d70d0b18881d11cf5321352207bb5 result = new RL_cc0d70d0b18881d11cf5321352207bb5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc0d70d0b18881d11cf5321352207bb5 FromRestList<T>(RestList<T> restList, Func <T, RC_404aa878a81887880a35de683904d643> converter) {
  RL_cc0d70d0b18881d11cf5321352207bb5 result = new RL_cc0d70d0b18881d11cf5321352207bb5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc0d70d0b18881d11cf5321352207bb5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_404aa878a81887880a35de683904d643> NewList() {
return new RL_cc0d70d0b18881d11cf5321352207bb5();
}


} // RL_cc0d70d0b18881d11cf5321352207bb5
}

