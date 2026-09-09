namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ChartLegendOptionalConfigs (sYRUw16gXku9AMOndLiWhw)
///  <code>ST_24000c8fde24da45a0d83940a64dbbafStructure</code> that represent
/// s <code>ChartLegendOptionalConfigs</code> <p>Description: Set additional parameters to customize
///  the chart series legend behavior and functionality.</p>
/// </summary>
// Name: ChartLegendOptionalConfigs
public partial struct ST_24000c8fde24da45a0d83940a64dbbafStructure : ITypedRecord<ST_24000c8fde24da45a0d83940a64dbbafStructure> {
internal static readonly GlobalObjectKey IdFloating = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*c0YFpxFpAkiDaFkztFapkw");

public bool ssFloating;


public BitArray OptimizedAttributes;

public ST_24000c8fde24da45a0d83940a64dbbafStructure() {
OptimizedAttributes = null;
ssFloating = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssFloating = r.ReadBoolean(index++, "ChartLegendOptionalConfigs.Floating", false);
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
public void ReadIM(ST_24000c8fde24da45a0d83940a64dbbafStructure r) {
this = r;
}


public static bool operator == (ST_24000c8fde24da45a0d83940a64dbbafStructure a, ST_24000c8fde24da45a0d83940a64dbbafStructure b) {
if (a.ssFloating != b.ssFloating) return false;
return true;
}

public static bool operator != (ST_24000c8fde24da45a0d83940a64dbbafStructure a, ST_24000c8fde24da45a0d83940a64dbbafStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_24000c8fde24da45a0d83940a64dbbafStructure)) return false;
return (this == (ST_24000c8fde24da45a0d83940a64dbbafStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFloating.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_24000c8fde24da45a0d83940a64dbbafStructure Duplicate() {
ST_24000c8fde24da45a0d83940a64dbbafStructure t;
t.ssFloating = this.ssFloating;
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
if (head == "floating") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Floating")) variable.Value = ssFloating; else variable.Optimized = true;
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
if (key == IdFloating) {
return ssFloating;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFloating.Key.AsGuid) {
return ssFloating;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFloating = (bool) other.AttributeGet(IdFloating);
}
} // ST_24000c8fde24da45a0d83940a64dbbafStructure
/// <summary>
/// RecordList type <code>ChartLegendOptionalConfigsList</code> that represents a record list of
///  <code>ChartLegendOptionalConfigs</code>
/// </summary>
public partial class RL_928b309e47d3fee06ffa327ba5f3019b : GenericRecordList<ST_24000c8fde24da45a0d83940a64dbbafStructure>, IEnumerable, IEnumerator {

protected override ST_24000c8fde24da45a0d83940a64dbbafStructure GetElementDefaultValue() {
return new ST_24000c8fde24da45a0d83940a64dbbafStructure();
}

public T[] ToArray<T>(Func<ST_24000c8fde24da45a0d83940a64dbbafStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_928b309e47d3fee06ffa327ba5f3019b recordList, Func<ST_24000c8fde24da45a0d83940a64dbbafStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_928b309e47d3fee06ffa327ba5f3019b(ST_24000c8fde24da45a0d83940a64dbbafStructure[] array) {
  RL_928b309e47d3fee06ffa327ba5f3019b result = new RL_928b309e47d3fee06ffa327ba5f3019b();
result.InnerFromArray(array);
    return result;
}

public static RL_928b309e47d3fee06ffa327ba5f3019b ToList<T>(T[] array, Func <T, ST_24000c8fde24da45a0d83940a64dbbafStructure> converter) {
  RL_928b309e47d3fee06ffa327ba5f3019b result = new RL_928b309e47d3fee06ffa327ba5f3019b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_928b309e47d3fee06ffa327ba5f3019b FromRestList<T>(RestList<T> restList, Func <T, ST_24000c8fde24da45a0d83940a64dbbafStructure> converter) {
  RL_928b309e47d3fee06ffa327ba5f3019b result = new RL_928b309e47d3fee06ffa327ba5f3019b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_928b309e47d3fee06ffa327ba5f3019b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_24000c8fde24da45a0d83940a64dbbafStructure> NewList() {
return new RL_928b309e47d3fee06ffa327ba5f3019b();
}


} // RL_928b309e47d3fee06ffa327ba5f3019b
}

