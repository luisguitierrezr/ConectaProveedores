namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] SeriesStyling (XOKS7y_NjUOgveI3VC+2Iw)
///  <code>ST_6bed431434274b65c17cd0339b1ecaa5Structure</code> that represent
/// s <code>SeriesStyling</code> <p>Description: Define the styles for a given series of the chart.</p>
/// </summary>
// Name: SeriesStyling
public partial struct ST_6bed431434274b65c17cd0339b1ecaa5Structure : ITypedRecord<ST_6bed431434274b65c17cd0339b1ecaa5Structure> {
internal static readonly GlobalObjectKey IdFillColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*xCo4W4blYkaHgXItjGgfng");
internal static readonly GlobalObjectKey IdLineColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*WO6aByxGgEOYymFQgC0cJQ");
internal static readonly GlobalObjectKey IdLineWidth = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*OvZScVcp5U+NuZMk_KdJ1g");
internal static readonly GlobalObjectKey IdOpacity = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*+BJxl9QirE+LdKsBtG_1BA");

public string ssFillColor;

public string ssLineColor;

public string ssLineWidth;

public string ssOpacity;


public BitArray OptimizedAttributes;

public ST_6bed431434274b65c17cd0339b1ecaa5Structure() {
OptimizedAttributes = null;
ssFillColor = "";
ssLineColor = "";
ssLineWidth = "";
ssOpacity = "";
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
ssFillColor = r.ReadText(index++, "SeriesStyling.FillColor", "");
ssLineColor = r.ReadText(index++, "SeriesStyling.LineColor", "");
ssLineWidth = r.ReadText(index++, "SeriesStyling.LineWidth", "");
ssOpacity = r.ReadText(index++, "SeriesStyling.Opacity", "");
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
public void ReadIM(ST_6bed431434274b65c17cd0339b1ecaa5Structure r) {
this = r;
}


public static bool operator == (ST_6bed431434274b65c17cd0339b1ecaa5Structure a, ST_6bed431434274b65c17cd0339b1ecaa5Structure b) {
if (a.ssFillColor != b.ssFillColor) return false;
if (a.ssLineColor != b.ssLineColor) return false;
if (a.ssLineWidth != b.ssLineWidth) return false;
if (a.ssOpacity != b.ssOpacity) return false;
return true;
}

public static bool operator != (ST_6bed431434274b65c17cd0339b1ecaa5Structure a, ST_6bed431434274b65c17cd0339b1ecaa5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6bed431434274b65c17cd0339b1ecaa5Structure)) return false;
return (this == (ST_6bed431434274b65c17cd0339b1ecaa5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFillColor.GetHashCode()
 ^ ssLineColor.GetHashCode()
 ^ ssLineWidth.GetHashCode()
 ^ ssOpacity.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6bed431434274b65c17cd0339b1ecaa5Structure Duplicate() {
ST_6bed431434274b65c17cd0339b1ecaa5Structure t;
t.ssFillColor = this.ssFillColor;
t.ssLineColor = this.ssLineColor;
t.ssLineWidth = this.ssLineWidth;
t.ssOpacity = this.ssOpacity;
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
if (head == "fillcolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FillColor")) variable.Value = ssFillColor; else variable.Optimized = true;
} else if (head == "linecolor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LineColor")) variable.Value = ssLineColor; else variable.Optimized = true;
} else if (head == "linewidth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LineWidth")) variable.Value = ssLineWidth; else variable.Optimized = true;
} else if (head == "opacity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Opacity")) variable.Value = ssOpacity; else variable.Optimized = true;
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
if (key == IdFillColor) {
return ssFillColor;
}
if (key == IdLineColor) {
return ssLineColor;
}
if (key == IdLineWidth) {
return ssLineWidth;
}
if (key == IdOpacity) {
return ssOpacity;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFillColor.Key.AsGuid) {
return ssFillColor;
}
if (attributeKey == IdLineColor.Key.AsGuid) {
return ssLineColor;
}
if (attributeKey == IdLineWidth.Key.AsGuid) {
return ssLineWidth;
}
if (attributeKey == IdOpacity.Key.AsGuid) {
return ssOpacity;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFillColor = (string) other.AttributeGet(IdFillColor);
ssLineColor = (string) other.AttributeGet(IdLineColor);
ssLineWidth = (string) other.AttributeGet(IdLineWidth);
ssOpacity = (string) other.AttributeGet(IdOpacity);
}
} // ST_6bed431434274b65c17cd0339b1ecaa5Structure
/// <summary>
/// RecordList type <code>SeriesStylingList</code> that represents a record list of
///  <code>SeriesStyling</code>
/// </summary>
public partial class RL_48d4c629d7b0e572d393ee61d6511e0d : GenericRecordList<ST_6bed431434274b65c17cd0339b1ecaa5Structure>, IEnumerable, IEnumerator {

protected override ST_6bed431434274b65c17cd0339b1ecaa5Structure GetElementDefaultValue() {
return new ST_6bed431434274b65c17cd0339b1ecaa5Structure();
}

public T[] ToArray<T>(Func<ST_6bed431434274b65c17cd0339b1ecaa5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_48d4c629d7b0e572d393ee61d6511e0d recordList, Func<ST_6bed431434274b65c17cd0339b1ecaa5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_48d4c629d7b0e572d393ee61d6511e0d(ST_6bed431434274b65c17cd0339b1ecaa5Structure[] array) {
  RL_48d4c629d7b0e572d393ee61d6511e0d result = new RL_48d4c629d7b0e572d393ee61d6511e0d();
result.InnerFromArray(array);
    return result;
}

public static RL_48d4c629d7b0e572d393ee61d6511e0d ToList<T>(T[] array, Func <T, ST_6bed431434274b65c17cd0339b1ecaa5Structure> converter) {
  RL_48d4c629d7b0e572d393ee61d6511e0d result = new RL_48d4c629d7b0e572d393ee61d6511e0d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_48d4c629d7b0e572d393ee61d6511e0d FromRestList<T>(RestList<T> restList, Func <T, ST_6bed431434274b65c17cd0339b1ecaa5Structure> converter) {
  RL_48d4c629d7b0e572d393ee61d6511e0d result = new RL_48d4c629d7b0e572d393ee61d6511e0d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_48d4c629d7b0e572d393ee61d6511e0d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6bed431434274b65c17cd0339b1ecaa5Structure> NewList() {
return new RL_48d4c629d7b0e572d393ee61d6511e0d();
}


} // RL_48d4c629d7b0e572d393ee61d6511e0d
}

