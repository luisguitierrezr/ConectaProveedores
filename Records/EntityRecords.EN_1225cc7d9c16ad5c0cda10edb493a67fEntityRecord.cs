using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] SpecialWorkflows (6_7wGYU+_E+17GK9axCbfw)
///  <code>EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord</code> that represent
/// s <code>SpecialWorkflows</code> <p>Description: SpecialWorkflows </p>
/// </summary>
// Name: SpecialWorkflows
public partial struct EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord : ITypedRecord<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*EhUWrBwpAUKK1Db7MyViqQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*ZGXWgC8MokuhtIl6flol2Q");
internal static readonly GlobalObjectKey IdDescritpion = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*888MRcEQj0OvjFKEBR+SMg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*aWpc+v9HZEWIOntKSso_uQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*VYezhz8P+E+AMLYcF9ULEw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*1scFEfjOhU2x6kFbSZOZ9w");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*1gaVr50lTkSFixyyAtywOA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private string _ssDescritpion;
public string ssDescritpion{
  get{
      return _ssDescritpion;
  }
  set{
      if((_ssDescritpion!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescritpion = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssName = "";
_ssDescritpion = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "SpecialWorkflows.Id", 0L);
ssName = r.ReadText(index++, "SpecialWorkflows.Name", "");
ssDescritpion = r.ReadText(index++, "SpecialWorkflows.Descritpion", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "SpecialWorkflows.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "SpecialWorkflows.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "SpecialWorkflows.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "SpecialWorkflows.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord r) {
this = r;
}


public static bool operator == (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord a, EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssDescritpion != b.ssDescritpion) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord a, EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord)) return false;
return (this == (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssDescritpion.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord Duplicate() {
EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssDescritpion = this._ssDescritpion;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "descritpion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Descritpion")) variable.Value = ssDescritpion; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescritpion)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescritpion)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdDescritpion) {
return ssDescritpion;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdDescritpion.Key.AsGuid) {
return ssDescritpion;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssDescritpion = (string) other.AttributeGet(IdDescritpion);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescritpion);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescritpion);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord

/// <summary>
/// RecordList type <code>SpecialWorkflowsList</code> that represents a record list of
///  <code>SpecialWorkflows</code>
/// </summary>
public partial class RL_c725d4e762f7cd6b934eb0f69772fa15 : GenericRecordList<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord GetElementDefaultValue() {
return new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord();
}

public T[] ToArray<T>(Func<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c725d4e762f7cd6b934eb0f69772fa15 recordList, Func<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c725d4e762f7cd6b934eb0f69772fa15(EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord[] array) {
  RL_c725d4e762f7cd6b934eb0f69772fa15 result = new RL_c725d4e762f7cd6b934eb0f69772fa15();
result.InnerFromArray(array);
    return result;
}

public static RL_c725d4e762f7cd6b934eb0f69772fa15 ToList<T>(T[] array, Func <T, EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> converter) {
  RL_c725d4e762f7cd6b934eb0f69772fa15 result = new RL_c725d4e762f7cd6b934eb0f69772fa15();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c725d4e762f7cd6b934eb0f69772fa15 FromRestList<T>(RestList<T> restList, Func <T, EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> converter) {
  RL_c725d4e762f7cd6b934eb0f69772fa15 result = new RL_c725d4e762f7cd6b934eb0f69772fa15();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c725d4e762f7cd6b934eb0f69772fa15() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> NewList() {
return new RL_c725d4e762f7cd6b934eb0f69772fa15();
}


} // RL_c725d4e762f7cd6b934eb0f69772fa15
}
