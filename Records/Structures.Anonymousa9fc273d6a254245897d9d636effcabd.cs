namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (PSf8qSVqRUKJfZ1jbv_KvQ)
///  <code>RC_da02352775767d2a57ea4cd35cd18496</code> that represents <code>RequisitionLogsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RequisitionLogsRecord
public partial struct RC_da02352775767d2a57ea4cd35cd18496 : ITypedRecord<RC_da02352775767d2a57ea4cd35cd18496> {
internal static readonly GlobalObjectKey IdRequisitionLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JzUC2nZ1Kn1X6kzTXNGElg");

public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord ssENRequisitionLogs;


public static implicit operator EN_fca813b8ca96d6759e00225744caa7d4EntityRecord( RC_da02352775767d2a57ea4cd35cd18496 r) {
return r.ssENRequisitionLogs;
}

public static implicit operator RC_da02352775767d2a57ea4cd35cd18496 (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord r) {
RC_da02352775767d2a57ea4cd35cd18496 res = new RC_da02352775767d2a57ea4cd35cd18496 ();
res.ssENRequisitionLogs = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionLogs.ChangedAttributes = value;
}
get {
    return ssENRequisitionLogs.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_da02352775767d2a57ea4cd35cd18496() {
OptimizedAttributes = null;
ssENRequisitionLogs = new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionLogs.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionLogs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionLogs.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionLogs.Read( r, ref index);
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
public void ReadIM(RC_da02352775767d2a57ea4cd35cd18496 r) {
this = r;
}


public static bool operator == (RC_da02352775767d2a57ea4cd35cd18496 a, RC_da02352775767d2a57ea4cd35cd18496 b) {
if (a.ssENRequisitionLogs != b.ssENRequisitionLogs) return false;
return true;
}

public static bool operator != (RC_da02352775767d2a57ea4cd35cd18496 a, RC_da02352775767d2a57ea4cd35cd18496 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_da02352775767d2a57ea4cd35cd18496)) return false;
return (this == (RC_da02352775767d2a57ea4cd35cd18496)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionLogs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionLogs.InternalRecursiveSave();
}


public RC_da02352775767d2a57ea4cd35cd18496 Duplicate() {
RC_da02352775767d2a57ea4cd35cd18496 t;
t.ssENRequisitionLogs = (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord)this.ssENRequisitionLogs.Duplicate();
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
if (head == "requisitionlogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionLogs")) variable.Value = ssENRequisitionLogs; else variable.Optimized = true;
variable.SetFieldName("requisitionlogs");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionLogs.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionLogs.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionLogs) {
return ssENRequisitionLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionLogs.Key.AsGuid) {
return ssENRequisitionLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionLogs.FillFromOther((IRecord) other.AttributeGet(IdRequisitionLogs));
}
} // RC_da02352775767d2a57ea4cd35cd18496
/// <summary>
/// RecordList type <code>RequisitionLogsRecordList</code> that represents a record list of
///  <code>RequisitionLogs</code>
/// </summary>
public partial class RL_57c324e581f9aea86c504fb7e70730b1 : GenericRecordList<RC_da02352775767d2a57ea4cd35cd18496>, IEnumerable, IEnumerator {

protected override RC_da02352775767d2a57ea4cd35cd18496 GetElementDefaultValue() {
return new RC_da02352775767d2a57ea4cd35cd18496();
}

public T[] ToArray<T>(Func<RC_da02352775767d2a57ea4cd35cd18496, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_57c324e581f9aea86c504fb7e70730b1 recordList, Func<RC_da02352775767d2a57ea4cd35cd18496, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_57c324e581f9aea86c504fb7e70730b1(RC_da02352775767d2a57ea4cd35cd18496[] array) {
  RL_57c324e581f9aea86c504fb7e70730b1 result = new RL_57c324e581f9aea86c504fb7e70730b1();
result.InnerFromArray(array);
    return result;
}

public static RL_57c324e581f9aea86c504fb7e70730b1 ToList<T>(T[] array, Func <T, RC_da02352775767d2a57ea4cd35cd18496> converter) {
  RL_57c324e581f9aea86c504fb7e70730b1 result = new RL_57c324e581f9aea86c504fb7e70730b1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_57c324e581f9aea86c504fb7e70730b1 FromRestList<T>(RestList<T> restList, Func <T, RC_da02352775767d2a57ea4cd35cd18496> converter) {
  RL_57c324e581f9aea86c504fb7e70730b1 result = new RL_57c324e581f9aea86c504fb7e70730b1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_57c324e581f9aea86c504fb7e70730b1() : base() {
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
protected override OSList<RC_da02352775767d2a57ea4cd35cd18496> NewList() {
return new RL_57c324e581f9aea86c504fb7e70730b1();
}


} // RL_57c324e581f9aea86c504fb7e70730b1
}

