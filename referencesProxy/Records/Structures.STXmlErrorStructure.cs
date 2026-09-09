namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] XmlError (0+poFqaohUeHlWEQs+Aqvw) <code>STXmlErrorStructure</code> that
///  represents <code>XmlError</code> <p>Description: </p>
/// </summary>
// Name: XmlError
public partial struct STXmlErrorStructure : ITypedRecord<STXmlErrorStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdSeverity = GlobalObjectKey.Parse("LKcSRcvo_U+zOMFWVZkA1Q*9FfvwGhvUjecZcJgcSWKTA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("LKcSRcvo_U+zOMFWVZkA1Q*YLSJhgOCjB8OieWgilFQ5w");

public string ssSeverity;

public string ssMessage;


public BitArray OptimizedAttributes;

public STXmlErrorStructure() {
OptimizedAttributes = null;
ssSeverity = "";
ssMessage = "";
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
ssSeverity = r.ReadText(index++, "XmlError.Severity", "");
ssMessage = r.ReadText(index++, "XmlError.Message", "");
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
public void ReadIM(STXmlErrorStructure r) {
this = r;
}


public static bool operator == (STXmlErrorStructure a, STXmlErrorStructure b) {
if (a.ssSeverity != b.ssSeverity) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (STXmlErrorStructure a, STXmlErrorStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STXmlErrorStructure)) return false;
return (this == (STXmlErrorStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSeverity.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STXmlErrorStructure Duplicate() {
STXmlErrorStructure t;
t.ssSeverity = this.ssSeverity;
t.ssMessage = this.ssMessage;
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
if (head == "severity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Severity")) variable.Value = ssSeverity; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdSeverity) {
return ssSeverity;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSeverity.Key.AsGuid) {
return ssSeverity;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSeverity = (string) other.AttributeGet(IdSeverity);
ssMessage = (string) other.AttributeGet(IdMessage);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSeverity = (string) other.GetAttribute(IdSeverity.Key.AsGuid);
ssMessage = (string) other.GetAttribute(IdMessage.Key.AsGuid);
}
} // STXmlErrorStructure
/// <summary>
/// RecordList type <code>XmlErrorList</code> that represents a record list of <code>XmlError</code>
/// </summary>
public partial class RLXmlErrorList : GenericRecordList<STXmlErrorStructure>, IEnumerable, IEnumerator {

protected override STXmlErrorStructure GetElementDefaultValue() {
return new STXmlErrorStructure();
}

public T[] ToArray<T>(Func<STXmlErrorStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLXmlErrorList recordList, Func<STXmlErrorStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLXmlErrorList(STXmlErrorStructure[] array) {
  RLXmlErrorList result = new RLXmlErrorList();
result.InnerFromArray(array);
    return result;
}

public static RLXmlErrorList ToList<T>(T[] array, Func <T, STXmlErrorStructure> converter) {
  RLXmlErrorList result = new RLXmlErrorList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLXmlErrorList FromRestList<T>(RestList<T> restList, Func <T, STXmlErrorStructure> converter) {
  RLXmlErrorList result = new RLXmlErrorList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLXmlErrorList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STXmlErrorStructure> NewList() {
return new RLXmlErrorList();
}


} // RLXmlErrorList
}

