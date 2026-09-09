namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ChartLegendStyling (NMP93nd0gEaEkbJW9Si2VQ)
///  <code>ST_4bdf4d0ba65c5e31172d7b508a740391Structure</code> that represent
/// s <code>ChartLegendStyling</code> <p>Description: Define the styles for the legend of the
///  chart.</p>
/// </summary>
// Name: ChartLegendStyling
public partial struct ST_4bdf4d0ba65c5e31172d7b508a740391Structure : ITypedRecord<ST_4bdf4d0ba65c5e31172d7b508a740391Structure> {
internal static readonly GlobalObjectKey IdBackgroundColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*vq0Rdx62mkCBwsZJ9IsMxQ");
internal static readonly GlobalObjectKey IdItemsDistance = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*ljMiXqASPkKmvONgV7eilw");

public string ssBackgroundColor;

public int ssItemsDistance;


public BitArray OptimizedAttributes;

public ST_4bdf4d0ba65c5e31172d7b508a740391Structure() {
OptimizedAttributes = null;
ssBackgroundColor = RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_ChartLegendStyling_ReferenceStructureAttribute_BackgroundColor;
ssItemsDistance = 20;
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
ssBackgroundColor = r.ReadText(index++, "ChartLegendStyling.BackgroundColor", "");
ssItemsDistance = r.ReadInteger(index++, "ChartLegendStyling.ItemsDistance", 0);
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
public void ReadIM(ST_4bdf4d0ba65c5e31172d7b508a740391Structure r) {
this = r;
}


public static bool operator == (ST_4bdf4d0ba65c5e31172d7b508a740391Structure a, ST_4bdf4d0ba65c5e31172d7b508a740391Structure b) {
if (a.ssBackgroundColor != b.ssBackgroundColor) return false;
if (a.ssItemsDistance != b.ssItemsDistance) return false;
return true;
}

public static bool operator != (ST_4bdf4d0ba65c5e31172d7b508a740391Structure a, ST_4bdf4d0ba65c5e31172d7b508a740391Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4bdf4d0ba65c5e31172d7b508a740391Structure)) return false;
return (this == (ST_4bdf4d0ba65c5e31172d7b508a740391Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssBackgroundColor.GetHashCode()
 ^ ssItemsDistance.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_4bdf4d0ba65c5e31172d7b508a740391Structure Duplicate() {
ST_4bdf4d0ba65c5e31172d7b508a740391Structure t;
t.ssBackgroundColor = this.ssBackgroundColor;
t.ssItemsDistance = this.ssItemsDistance;
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
if (head == "backgroundcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BackgroundColor")) variable.Value = ssBackgroundColor; else variable.Optimized = true;
} else if (head == "itemsdistance") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemsDistance")) variable.Value = ssItemsDistance; else variable.Optimized = true;
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
if (key == IdBackgroundColor) {
return ssBackgroundColor;
}
if (key == IdItemsDistance) {
return ssItemsDistance;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBackgroundColor.Key.AsGuid) {
return ssBackgroundColor;
}
if (attributeKey == IdItemsDistance.Key.AsGuid) {
return ssItemsDistance;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssBackgroundColor = (string) other.AttributeGet(IdBackgroundColor);
ssItemsDistance = (int) other.AttributeGet(IdItemsDistance);
}
} // ST_4bdf4d0ba65c5e31172d7b508a740391Structure
/// <summary>
/// RecordList type <code>ChartLegendStylingList</code> that represents a record list of
///  <code>ChartLegendStyling</code>
/// </summary>
public partial class RL_88caf95e46b56f6f49fb935e6edee4c9 : GenericRecordList<ST_4bdf4d0ba65c5e31172d7b508a740391Structure>, IEnumerable, IEnumerator {

protected override ST_4bdf4d0ba65c5e31172d7b508a740391Structure GetElementDefaultValue() {
return new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
}

public T[] ToArray<T>(Func<ST_4bdf4d0ba65c5e31172d7b508a740391Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88caf95e46b56f6f49fb935e6edee4c9 recordList, Func<ST_4bdf4d0ba65c5e31172d7b508a740391Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88caf95e46b56f6f49fb935e6edee4c9(ST_4bdf4d0ba65c5e31172d7b508a740391Structure[] array) {
  RL_88caf95e46b56f6f49fb935e6edee4c9 result = new RL_88caf95e46b56f6f49fb935e6edee4c9();
result.InnerFromArray(array);
    return result;
}

public static RL_88caf95e46b56f6f49fb935e6edee4c9 ToList<T>(T[] array, Func <T, ST_4bdf4d0ba65c5e31172d7b508a740391Structure> converter) {
  RL_88caf95e46b56f6f49fb935e6edee4c9 result = new RL_88caf95e46b56f6f49fb935e6edee4c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88caf95e46b56f6f49fb935e6edee4c9 FromRestList<T>(RestList<T> restList, Func <T, ST_4bdf4d0ba65c5e31172d7b508a740391Structure> converter) {
  RL_88caf95e46b56f6f49fb935e6edee4c9 result = new RL_88caf95e46b56f6f49fb935e6edee4c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88caf95e46b56f6f49fb935e6edee4c9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4bdf4d0ba65c5e31172d7b508a740391Structure> NewList() {
return new RL_88caf95e46b56f6f49fb935e6edee4c9();
}


} // RL_88caf95e46b56f6f49fb935e6edee4c9
}

