namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] DropdownOption (ZKllc7mIg0ihVwLWmI7emw)
///  <code>ST_60f22bd2e9b10a22278b8afe6d7f601aStructure</code> that represent
/// s <code>DropdownOption</code> <p>Description: Structure used on Dropdown option items.</p>
/// </summary>
// Name: DropdownOption
public partial struct ST_60f22bd2e9b10a22278b8afe6d7f601aStructure : ITypedRecord<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*s5LvBcaNcEi9oXU8LaszTQ");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*KySXRx40ak2_mPcsb9LiSw");
internal static readonly GlobalObjectKey IdImageUrlOrIconClass = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1ipGluiVkEyjkPK316pD_A");
internal static readonly GlobalObjectKey IdGroupName = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ao5DsniK0kiwO+ml1_Uz4g");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MPZj+8kq6Uad62UKdq755Q");

public string ssValue;

public string ssLabel;

public string ssImageUrlOrIconClass;

public string ssGroupName;

public string ssDescription;


public BitArray OptimizedAttributes;

public ST_60f22bd2e9b10a22278b8afe6d7f601aStructure() {
OptimizedAttributes = null;
ssValue = "";
ssLabel = "";
ssImageUrlOrIconClass = "";
ssGroupName = "";
ssDescription = "";
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
ssValue = r.ReadText(index++, "DropdownOption.Value", "");
ssLabel = r.ReadText(index++, "DropdownOption.Label", "");
ssImageUrlOrIconClass = r.ReadText(index++, "DropdownOption.ImageUrlOrIconClass", "");
ssGroupName = r.ReadText(index++, "DropdownOption.GroupName", "");
ssDescription = r.ReadText(index++, "DropdownOption.Description", "");
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
public void ReadIM(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure r) {
this = r;
}


public static bool operator == (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure a, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure b) {
if (a.ssValue != b.ssValue) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssImageUrlOrIconClass != b.ssImageUrlOrIconClass) return false;
if (a.ssGroupName != b.ssGroupName) return false;
if (a.ssDescription != b.ssDescription) return false;
return true;
}

public static bool operator != (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure a, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)) return false;
return (this == (ST_60f22bd2e9b10a22278b8afe6d7f601aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssImageUrlOrIconClass.GetHashCode()
 ^ ssGroupName.GetHashCode()
 ^ ssDescription.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_60f22bd2e9b10a22278b8afe6d7f601aStructure Duplicate() {
ST_60f22bd2e9b10a22278b8afe6d7f601aStructure t;
t.ssValue = this.ssValue;
t.ssLabel = this.ssLabel;
t.ssImageUrlOrIconClass = this.ssImageUrlOrIconClass;
t.ssGroupName = this.ssGroupName;
t.ssDescription = this.ssDescription;
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
} else if (head == "imageurloriconclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImageUrlOrIconClass")) variable.Value = ssImageUrlOrIconClass; else variable.Optimized = true;
} else if (head == "groupname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GroupName")) variable.Value = ssGroupName; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
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
if (key == IdImageUrlOrIconClass) {
return ssImageUrlOrIconClass;
}
if (key == IdGroupName) {
return ssGroupName;
}
if (key == IdDescription) {
return ssDescription;
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
if (attributeKey == IdImageUrlOrIconClass.Key.AsGuid) {
return ssImageUrlOrIconClass;
}
if (attributeKey == IdGroupName.Key.AsGuid) {
return ssGroupName;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (string) other.AttributeGet(IdValue);
ssLabel = (string) other.AttributeGet(IdLabel);
ssImageUrlOrIconClass = (string) other.AttributeGet(IdImageUrlOrIconClass);
ssGroupName = (string) other.AttributeGet(IdGroupName);
ssDescription = (string) other.AttributeGet(IdDescription);
}
} // ST_60f22bd2e9b10a22278b8afe6d7f601aStructure
/// <summary>
/// RecordList type <code>DropdownOptionList</code> that represents a record list of
///  <code>DropdownOption</code>
/// </summary>
public partial class RL_c0f17d75c546075264f5d075e00ba65b : GenericRecordList<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure>, IEnumerable, IEnumerator {

protected override ST_60f22bd2e9b10a22278b8afe6d7f601aStructure GetElementDefaultValue() {
return new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
}

public T[] ToArray<T>(Func<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c0f17d75c546075264f5d075e00ba65b recordList, Func<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c0f17d75c546075264f5d075e00ba65b(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure[] array) {
  RL_c0f17d75c546075264f5d075e00ba65b result = new RL_c0f17d75c546075264f5d075e00ba65b();
result.InnerFromArray(array);
    return result;
}

public static RL_c0f17d75c546075264f5d075e00ba65b ToList<T>(T[] array, Func <T, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> converter) {
  RL_c0f17d75c546075264f5d075e00ba65b result = new RL_c0f17d75c546075264f5d075e00ba65b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c0f17d75c546075264f5d075e00ba65b FromRestList<T>(RestList<T> restList, Func <T, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> converter) {
  RL_c0f17d75c546075264f5d075e00ba65b result = new RL_c0f17d75c546075264f5d075e00ba65b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c0f17d75c546075264f5d075e00ba65b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_60f22bd2e9b10a22278b8afe6d7f601aStructure> NewList() {
return new RL_c0f17d75c546075264f5d075e00ba65b();
}


} // RL_c0f17d75c546075264f5d075e00ba65b
}

