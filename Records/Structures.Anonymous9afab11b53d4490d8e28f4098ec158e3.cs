namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (G7H6mtRTDUmOKPQJjsFY4w)
///  <code>RC_25c6d4ad26c50e9400baa0d709166594</code> that represents <code>ColumnSettingsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ColumnSettingsRecord
public partial struct RC_25c6d4ad26c50e9400baa0d709166594 : ITypedRecord<RC_25c6d4ad26c50e9400baa0d709166594> {
internal static readonly GlobalObjectKey IdColumnSettings = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rdTGJcUmlA4AuqDXCRZllA");

public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord ssENColumnSettings;


public static implicit operator EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord( RC_25c6d4ad26c50e9400baa0d709166594 r) {
return r.ssENColumnSettings;
}

public static implicit operator RC_25c6d4ad26c50e9400baa0d709166594 (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord r) {
RC_25c6d4ad26c50e9400baa0d709166594 res = new RC_25c6d4ad26c50e9400baa0d709166594 ();
res.ssENColumnSettings = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENColumnSettings.ChangedAttributes = value;
}
get {
    return ssENColumnSettings.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_25c6d4ad26c50e9400baa0d709166594() {
OptimizedAttributes = null;
ssENColumnSettings = new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENColumnSettings.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENColumnSettings.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENColumnSettings.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENColumnSettings.Read( r, ref index);
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
public void ReadIM(RC_25c6d4ad26c50e9400baa0d709166594 r) {
this = r;
}


public static bool operator == (RC_25c6d4ad26c50e9400baa0d709166594 a, RC_25c6d4ad26c50e9400baa0d709166594 b) {
if (a.ssENColumnSettings != b.ssENColumnSettings) return false;
return true;
}

public static bool operator != (RC_25c6d4ad26c50e9400baa0d709166594 a, RC_25c6d4ad26c50e9400baa0d709166594 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_25c6d4ad26c50e9400baa0d709166594)) return false;
return (this == (RC_25c6d4ad26c50e9400baa0d709166594)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENColumnSettings.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENColumnSettings.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENColumnSettings.InternalRecursiveSave();
}


public RC_25c6d4ad26c50e9400baa0d709166594 Duplicate() {
RC_25c6d4ad26c50e9400baa0d709166594 t;
t.ssENColumnSettings = (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord)this.ssENColumnSettings.Duplicate();
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
if (head == "columnsettings") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnSettings")) variable.Value = ssENColumnSettings; else variable.Optimized = true;
variable.SetFieldName("columnsettings");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENColumnSettings.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENColumnSettings.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColumnSettings) {
return ssENColumnSettings;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColumnSettings.Key.AsGuid) {
return ssENColumnSettings;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENColumnSettings.FillFromOther((IRecord) other.AttributeGet(IdColumnSettings));
}
} // RC_25c6d4ad26c50e9400baa0d709166594
/// <summary>
/// RecordList type <code>ColumnSettingsRecordList</code> that represents a record list of
///  <code>ColumnSettings</code>
/// </summary>
public partial class RL_12d8bb3d9ae5ae3d570d3e14f2e9595e : GenericRecordList<RC_25c6d4ad26c50e9400baa0d709166594>, IEnumerable, IEnumerator {

protected override RC_25c6d4ad26c50e9400baa0d709166594 GetElementDefaultValue() {
return new RC_25c6d4ad26c50e9400baa0d709166594();
}

public T[] ToArray<T>(Func<RC_25c6d4ad26c50e9400baa0d709166594, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_12d8bb3d9ae5ae3d570d3e14f2e9595e recordList, Func<RC_25c6d4ad26c50e9400baa0d709166594, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_12d8bb3d9ae5ae3d570d3e14f2e9595e(RC_25c6d4ad26c50e9400baa0d709166594[] array) {
  RL_12d8bb3d9ae5ae3d570d3e14f2e9595e result = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
result.InnerFromArray(array);
    return result;
}

public static RL_12d8bb3d9ae5ae3d570d3e14f2e9595e ToList<T>(T[] array, Func <T, RC_25c6d4ad26c50e9400baa0d709166594> converter) {
  RL_12d8bb3d9ae5ae3d570d3e14f2e9595e result = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_12d8bb3d9ae5ae3d570d3e14f2e9595e FromRestList<T>(RestList<T> restList, Func <T, RC_25c6d4ad26c50e9400baa0d709166594> converter) {
  RL_12d8bb3d9ae5ae3d570d3e14f2e9595e result = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_12d8bb3d9ae5ae3d570d3e14f2e9595e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_25c6d4ad26c50e9400baa0d709166594> NewList() {
return new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
}


} // RL_12d8bb3d9ae5ae3d570d3e14f2e9595e
}

