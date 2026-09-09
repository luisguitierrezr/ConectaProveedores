namespace ssConectaProveedores {
/// <summary>
/// [Structure] HomepageKPI (GSUvQ5aF6UmTJlu75hLgVw)
///  <code>ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure</code> that represents <code>HomepageKPI</code
/// > <p>Description: </p>
/// </summary>
// Name: HomepageKPI
public partial struct ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure : ITypedRecord<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> {
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W7KYClHjyEO+Tzam_8YCQg");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ln4i_F9tV0OHe2KmJnjnPg");

public int ssCount;

public string ssLabel;


public BitArray OptimizedAttributes;

public ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure() {
OptimizedAttributes = null;
ssCount = 0;
ssLabel = "";
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
ssCount = r.ReadInteger(index++, "HomepageKPI.Count", 0);
ssLabel = r.ReadText(index++, "HomepageKPI.Label", "");
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
public void ReadIM(ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure r) {
this = r;
}


public static bool operator == (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure a, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure b) {
if (a.ssCount != b.ssCount) return false;
if (a.ssLabel != b.ssLabel) return false;
return true;
}

public static bool operator != (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure a, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure)) return false;
return (this == (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCount.GetHashCode()
 ^ ssLabel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure Duplicate() {
ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure t;
t.ssCount = this.ssCount;
t.ssLabel = this.ssLabel;
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
if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
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
if (key == IdCount) {
return ssCount;
}
if (key == IdLabel) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCount = (int) other.AttributeGet(IdCount);
ssLabel = (string) other.AttributeGet(IdLabel);
}
} // ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure
/// <summary>
/// RecordList type <code>HomepageKPIList</code> that represents a record list of
///  <code>HomepageKPI</code>
/// </summary>
public partial class RL_95e11a982864fe07082eb4aea44bdce2 : GenericRecordList<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure>, IEnumerable, IEnumerator {

protected override ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure GetElementDefaultValue() {
return new ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure();
}

public T[] ToArray<T>(Func<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95e11a982864fe07082eb4aea44bdce2 recordList, Func<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95e11a982864fe07082eb4aea44bdce2(ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure[] array) {
  RL_95e11a982864fe07082eb4aea44bdce2 result = new RL_95e11a982864fe07082eb4aea44bdce2();
result.InnerFromArray(array);
    return result;
}

public static RL_95e11a982864fe07082eb4aea44bdce2 ToList<T>(T[] array, Func <T, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> converter) {
  RL_95e11a982864fe07082eb4aea44bdce2 result = new RL_95e11a982864fe07082eb4aea44bdce2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95e11a982864fe07082eb4aea44bdce2 FromRestList<T>(RestList<T> restList, Func <T, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> converter) {
  RL_95e11a982864fe07082eb4aea44bdce2 result = new RL_95e11a982864fe07082eb4aea44bdce2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95e11a982864fe07082eb4aea44bdce2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> NewList() {
return new RL_95e11a982864fe07082eb4aea44bdce2();
}


} // RL_95e11a982864fe07082eb4aea44bdce2
}

