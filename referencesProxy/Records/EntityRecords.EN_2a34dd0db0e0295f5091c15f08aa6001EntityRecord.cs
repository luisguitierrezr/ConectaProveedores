using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] SegmentAccGroupTelcelDir (BHUv_AYZekGeShwXT5khJA)
///  <code>EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord</code> that represent
/// s <code>SegmentAccGroupTelcelDir</code> <p>Description: Group direcciones to segment Gerencia de
///  Cuentas Por Pagar, Seguros y Fianzas</p>
/// </summary>
// Name: SegmentAccGroupTelcelDir
public partial struct EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord : ITypedRecord<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Lb9ia4Th2UC1nymI1w60oA");
internal static readonly GlobalObjectKey IdSegmentAccGroupId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*GRV3fNM0i0iOF2hIWp9x1A");
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*G4rNG0PzFUGqoCcQpe7EWA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*5nr_t7m2zEydZN1mwrzBsw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*RzCGk+tCPUyQ0eOz4o6jkg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private long _ssSegmentAccGroupId;
public long ssSegmentAccGroupId{
  get{
      return _ssSegmentAccGroupId;
  }
  set{
      if((_ssSegmentAccGroupId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSegmentAccGroupId = value;
      }
  }
}

private long _ssTelcelDirectionId;
public long ssTelcelDirectionId{
  get{
      return _ssTelcelDirectionId;
  }
  set{
      if((_ssTelcelDirectionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTelcelDirectionId = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssSegmentAccGroupId = 0L;
_ssTelcelDirectionId = 0L;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "SegmentAccGroupTelcelDir.Id", 0L);
ssSegmentAccGroupId = r.ReadEntityReferenceLongInteger(index++, "SegmentAccGroupTelcelDir.SegmentAccGroupId", 0L);
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "SegmentAccGroupTelcelDir.TelcelDirectionId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "SegmentAccGroupTelcelDir.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "SegmentAccGroupTelcelDir.CreatedBy", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord r) {
this = r;
}


public static bool operator == (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord a, EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSegmentAccGroupId != b.ssSegmentAccGroupId) return false;
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
return true;
}

public static bool operator != (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord a, EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord)) return false;
return (this == (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSegmentAccGroupId.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord Duplicate() {
EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord t;
t._ssId = this._ssId;
t._ssSegmentAccGroupId = this._ssSegmentAccGroupId;
t._ssTelcelDirectionId = this._ssTelcelDirectionId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "segmentaccgroupid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroupId")) variable.Value = ssSegmentAccGroupId; else variable.Optimized = true;
} else if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSegmentAccGroupId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTelcelDirectionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSegmentAccGroupId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTelcelDirectionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSegmentAccGroupId) {
return ssSegmentAccGroupId;
}
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSegmentAccGroupId.Key.AsGuid) {
return ssSegmentAccGroupId;
}
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSegmentAccGroupId = (long) other.AttributeGet(IdSegmentAccGroupId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSegmentAccGroupId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSegmentAccGroupId);
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTelcelDirectionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTelcelDirectionId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
}
} // EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord

/// <summary>
/// RecordList type <code>SegmentAccGroupTelcelDirList</code> that represents a record list of
///  <code>SegmentAccGroupTelcelDir</code>
/// </summary>
public partial class RL_7abfddba4915b729db7adb39d9cd38ca : GenericRecordList<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord>, IEnumerable, IEnumerator {

protected override EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord GetElementDefaultValue() {
return new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
}

public T[] ToArray<T>(Func<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7abfddba4915b729db7adb39d9cd38ca recordList, Func<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7abfddba4915b729db7adb39d9cd38ca(EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord[] array) {
  RL_7abfddba4915b729db7adb39d9cd38ca result = new RL_7abfddba4915b729db7adb39d9cd38ca();
result.InnerFromArray(array);
    return result;
}

public static RL_7abfddba4915b729db7adb39d9cd38ca ToList<T>(T[] array, Func <T, EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> converter) {
  RL_7abfddba4915b729db7adb39d9cd38ca result = new RL_7abfddba4915b729db7adb39d9cd38ca();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7abfddba4915b729db7adb39d9cd38ca FromRestList<T>(RestList<T> restList, Func <T, EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> converter) {
  RL_7abfddba4915b729db7adb39d9cd38ca result = new RL_7abfddba4915b729db7adb39d9cd38ca();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7abfddba4915b729db7adb39d9cd38ca() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord> NewList() {
return new RL_7abfddba4915b729db7adb39d9cd38ca();
}


} // RL_7abfddba4915b729db7adb39d9cd38ca
}
