namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] DataPoint (yzh_nbymR0CtcJtrl05iaw)
///  <code>ST_34313c5cf94d7ce3c5404858c22fafd9Structure</code> that represents <code>DataPoint</code
/// > <p>Description: Information to plot a data point on the chart.</p>
/// </summary>
// Name: DataPoint
public partial struct ST_34313c5cf94d7ce3c5404858c22fafd9Structure : ITypedRecord<ST_34313c5cf94d7ce3c5404858c22fafd9Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*3F67GJHA3Uyd8Ac6hU9e4w");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*MjkaiN879U214BJP0OQ6dg");
internal static readonly GlobalObjectKey IdSeriesName = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*ix9MNopZOUmxr5iVKqColw");
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*3ub4whB9L0SuRbggIpLRWQ");
internal static readonly GlobalObjectKey IdTooltip = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*0uu2VPxFTkSra45CNMzGjw");

public decimal ssValue;

public string ssLabel;

public string ssSeriesName;

public string ssColor;

public string ssTooltip;


public BitArray OptimizedAttributes;

public ST_34313c5cf94d7ce3c5404858c22fafd9Structure() {
OptimizedAttributes = null;
ssValue = 0.0M;
ssLabel = "";
ssSeriesName = "";
ssColor = "";
ssTooltip = "";
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
ssValue = r.ReadDecimal(index++, "DataPoint.Value", 0.0M);
ssLabel = r.ReadText(index++, "DataPoint.Label", "");
ssSeriesName = r.ReadText(index++, "DataPoint.SeriesName", "");
ssColor = r.ReadText(index++, "DataPoint.Color", "");
ssTooltip = r.ReadText(index++, "DataPoint.Tooltip", "");
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
public void ReadIM(ST_34313c5cf94d7ce3c5404858c22fafd9Structure r) {
this = r;
}


public static bool operator == (ST_34313c5cf94d7ce3c5404858c22fafd9Structure a, ST_34313c5cf94d7ce3c5404858c22fafd9Structure b) {
if (a.ssValue != b.ssValue) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssSeriesName != b.ssSeriesName) return false;
if (a.ssColor != b.ssColor) return false;
if (a.ssTooltip != b.ssTooltip) return false;
return true;
}

public static bool operator != (ST_34313c5cf94d7ce3c5404858c22fafd9Structure a, ST_34313c5cf94d7ce3c5404858c22fafd9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_34313c5cf94d7ce3c5404858c22fafd9Structure)) return false;
return (this == (ST_34313c5cf94d7ce3c5404858c22fafd9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssSeriesName.GetHashCode()
 ^ ssColor.GetHashCode()
 ^ ssTooltip.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_34313c5cf94d7ce3c5404858c22fafd9Structure Duplicate() {
ST_34313c5cf94d7ce3c5404858c22fafd9Structure t;
t.ssValue = this.ssValue;
t.ssLabel = this.ssLabel;
t.ssSeriesName = this.ssSeriesName;
t.ssColor = this.ssColor;
t.ssTooltip = this.ssTooltip;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "seriesname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeriesName")) variable.Value = ssSeriesName; else variable.Optimized = true;
} else if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
} else if (head == "tooltip") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tooltip")) variable.Value = ssTooltip; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdSeriesName) {
return ssSeriesName;
}
if (key == IdColor) {
return ssColor;
}
if (key == IdTooltip) {
return ssTooltip;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdSeriesName.Key.AsGuid) {
return ssSeriesName;
}
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
if (attributeKey == IdTooltip.Key.AsGuid) {
return ssTooltip;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (decimal) other.AttributeGet(IdValue);
ssLabel = (string) other.AttributeGet(IdLabel);
ssSeriesName = (string) other.AttributeGet(IdSeriesName);
ssColor = (string) other.AttributeGet(IdColor);
ssTooltip = (string) other.AttributeGet(IdTooltip);
}
} // ST_34313c5cf94d7ce3c5404858c22fafd9Structure
/// <summary>
/// RecordList type <code>DataPointList</code> that represents a record list of <code>DataPoint</code>
/// </summary>
public partial class RL_7d9c239ab2336eba85802eb00151e260 : GenericRecordList<ST_34313c5cf94d7ce3c5404858c22fafd9Structure>, IEnumerable, IEnumerator {

protected override ST_34313c5cf94d7ce3c5404858c22fafd9Structure GetElementDefaultValue() {
return new ST_34313c5cf94d7ce3c5404858c22fafd9Structure();
}

public T[] ToArray<T>(Func<ST_34313c5cf94d7ce3c5404858c22fafd9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7d9c239ab2336eba85802eb00151e260 recordList, Func<ST_34313c5cf94d7ce3c5404858c22fafd9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7d9c239ab2336eba85802eb00151e260(ST_34313c5cf94d7ce3c5404858c22fafd9Structure[] array) {
  RL_7d9c239ab2336eba85802eb00151e260 result = new RL_7d9c239ab2336eba85802eb00151e260();
result.InnerFromArray(array);
    return result;
}

public static RL_7d9c239ab2336eba85802eb00151e260 ToList<T>(T[] array, Func <T, ST_34313c5cf94d7ce3c5404858c22fafd9Structure> converter) {
  RL_7d9c239ab2336eba85802eb00151e260 result = new RL_7d9c239ab2336eba85802eb00151e260();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7d9c239ab2336eba85802eb00151e260 FromRestList<T>(RestList<T> restList, Func <T, ST_34313c5cf94d7ce3c5404858c22fafd9Structure> converter) {
  RL_7d9c239ab2336eba85802eb00151e260 result = new RL_7d9c239ab2336eba85802eb00151e260();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7d9c239ab2336eba85802eb00151e260() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_34313c5cf94d7ce3c5404858c22fafd9Structure> NewList() {
return new RL_7d9c239ab2336eba85802eb00151e260();
}


} // RL_7d9c239ab2336eba85802eb00151e260
}

