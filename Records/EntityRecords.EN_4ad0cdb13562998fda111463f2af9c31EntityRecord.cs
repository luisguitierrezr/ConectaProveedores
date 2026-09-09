using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderDistributionConfig (C_P8AVTyFkWuRXDzlQncYw)
///  <code>EN_4ad0cdb13562998fda111463f2af9c31EntityRecord</code> that represent
/// s <code>OrderDistributionConfig</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionConfig
public partial struct EN_4ad0cdb13562998fda111463f2af9c31EntityRecord : ITypedRecord<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GyF4KTbT3UGshFhrYMl+kw");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_R1U5fb+a0mQ2y8ply+XMg");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ze3fXP9jgES4JQTipoWUVA");
internal static readonly GlobalObjectKey IdApplicantDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R1biyNjUk0O84GP4YpbfrA");
internal static readonly GlobalObjectKey IdDirectionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L+rXv7VwaEaBp1mAgbiFHw");
internal static readonly GlobalObjectKey IdFirstContact_EntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Mv8Sb0JJCE+fYv7EgDIbNQ");
internal static readonly GlobalObjectKey IdSecondContact_EntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hJ5HuwPCF0iQtml6mlxslg");
internal static readonly GlobalObjectKey IdFirstApprover_EntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WtU0kUvHrUmwbq5eguxp9w");
internal static readonly GlobalObjectKey IdSecondApprover_EntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7OggqT29hEaKQE9V_g8HvQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fkWwmI+KQUihgEO6uryyKg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Gz_2KhjkgEyRwOHZb6zuyQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FMLeJRyn_0qW7kpQvOvf6w");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_AmpbGMbl0CrAZjqKFGj5w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(13,true);
          _ssId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRegionId = value;
      }
  }
}

private string _ssApplicant;
public string ssApplicant{
  get{
      return _ssApplicant;
  }
  set{
      if((_ssApplicant!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApplicant = value;
      }
  }
}

private string _ssApplicantDescription;
public string ssApplicantDescription{
  get{
      return _ssApplicantDescription;
  }
  set{
      if((_ssApplicantDescription!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssApplicantDescription = value;
      }
  }
}

private long _ssDirectionId;
public long ssDirectionId{
  get{
      return _ssDirectionId;
  }
  set{
      if((_ssDirectionId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssDirectionId = value;
      }
  }
}

private long _ssFirstContact_EntraRoleId;
public long ssFirstContact_EntraRoleId{
  get{
      return _ssFirstContact_EntraRoleId;
  }
  set{
      if((_ssFirstContact_EntraRoleId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFirstContact_EntraRoleId = value;
      }
  }
}

private long _ssSecondContact_EntraRoleId;
public long ssSecondContact_EntraRoleId{
  get{
      return _ssSecondContact_EntraRoleId;
  }
  set{
      if((_ssSecondContact_EntraRoleId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssSecondContact_EntraRoleId = value;
      }
  }
}

private long _ssFirstApprover_EntraRoleId;
public long ssFirstApprover_EntraRoleId{
  get{
      return _ssFirstApprover_EntraRoleId;
  }
  set{
      if((_ssFirstApprover_EntraRoleId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssFirstApprover_EntraRoleId = value;
      }
  }
}

private long _ssSecondApprover_EntraRoleId;
public long ssSecondApprover_EntraRoleId{
  get{
      return _ssSecondApprover_EntraRoleId;
  }
  set{
      if((_ssSecondApprover_EntraRoleId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssSecondApprover_EntraRoleId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord() {
ChangedAttributes = new BitArray(13,true);
OptimizedAttributes = new BitArray(13,false);
_ssId = 0L;
_ssRegionId = 0L;
_ssApplicant = "";
_ssApplicantDescription = "";
_ssDirectionId = 0L;
_ssFirstContact_EntraRoleId = 0L;
_ssSecondContact_EntraRoleId = 0L;
_ssFirstApprover_EntraRoleId = 0L;
_ssSecondApprover_EntraRoleId = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderDistributionConfig.Id", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.RegionId", 0L);
ssApplicant = r.ReadText(index++, "OrderDistributionConfig.Applicant", "");
ssApplicantDescription = r.ReadText(index++, "OrderDistributionConfig.ApplicantDescription", "");
ssDirectionId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.DirectionId", 0L);
ssFirstContact_EntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.FirstContact_EntraRoleId", 0L);
ssSecondContact_EntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.SecondContact_EntraRoleId", 0L);
ssFirstApprover_EntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.FirstApprover_EntraRoleId", 0L);
ssSecondApprover_EntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderDistributionConfig.SecondApprover_EntraRoleId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderDistributionConfig.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderDistributionConfig.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "OrderDistributionConfig.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "OrderDistributionConfig.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(13,false);
OptimizedAttributes = new BitArray(13,false);
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
public void ReadIM(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord r) {
this = r;
}


public static bool operator == (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord a, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssApplicantDescription != b.ssApplicantDescription) return false;
if (a.ssDirectionId != b.ssDirectionId) return false;
if (a.ssFirstContact_EntraRoleId != b.ssFirstContact_EntraRoleId) return false;
if (a.ssSecondContact_EntraRoleId != b.ssSecondContact_EntraRoleId) return false;
if (a.ssFirstApprover_EntraRoleId != b.ssFirstApprover_EntraRoleId) return false;
if (a.ssSecondApprover_EntraRoleId != b.ssSecondApprover_EntraRoleId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord a, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord)) return false;
return (this == (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssApplicantDescription.GetHashCode()
 ^ ssDirectionId.GetHashCode()
 ^ ssFirstContact_EntraRoleId.GetHashCode()
 ^ ssSecondContact_EntraRoleId.GetHashCode()
 ^ ssFirstApprover_EntraRoleId.GetHashCode()
 ^ ssSecondApprover_EntraRoleId.GetHashCode()
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


public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord Duplicate() {
EN_4ad0cdb13562998fda111463f2af9c31EntityRecord t;
t._ssId = this._ssId;
t._ssRegionId = this._ssRegionId;
t._ssApplicant = this._ssApplicant;
t._ssApplicantDescription = this._ssApplicantDescription;
t._ssDirectionId = this._ssDirectionId;
t._ssFirstContact_EntraRoleId = this._ssFirstContact_EntraRoleId;
t._ssSecondContact_EntraRoleId = this._ssSecondContact_EntraRoleId;
t._ssFirstApprover_EntraRoleId = this._ssFirstApprover_EntraRoleId;
t._ssSecondApprover_EntraRoleId = this._ssSecondApprover_EntraRoleId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t.ChangedAttributes = new BitArray(13);
t.OptimizedAttributes = new BitArray(13);
for(int i = 0; i < 13; i++){
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
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "applicantdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantDescription")) variable.Value = ssApplicantDescription; else variable.Optimized = true;
} else if (head == "directionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectionId")) variable.Value = ssDirectionId; else variable.Optimized = true;
} else if (head == "firstcontact_entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstContact_EntraRoleId")) variable.Value = ssFirstContact_EntraRoleId; else variable.Optimized = true;
} else if (head == "secondcontact_entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondContact_EntraRoleId")) variable.Value = ssSecondContact_EntraRoleId; else variable.Optimized = true;
} else if (head == "firstapprover_entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstApprover_EntraRoleId")) variable.Value = ssFirstApprover_EntraRoleId; else variable.Optimized = true;
} else if (head == "secondapprover_entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondApprover_EntraRoleId")) variable.Value = ssSecondApprover_EntraRoleId; else variable.Optimized = true;
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
if (key.Equals(IdRegionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApplicant)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicantDescription)) {
return ChangedAttributes[3];
}
if (key.Equals(IdDirectionId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFirstContact_EntraRoleId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdSecondContact_EntraRoleId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdFirstApprover_EntraRoleId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdSecondApprover_EntraRoleId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[10];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[11];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[12];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApplicant)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicantDescription)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdDirectionId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFirstContact_EntraRoleId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdSecondContact_EntraRoleId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdFirstApprover_EntraRoleId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdSecondApprover_EntraRoleId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[12];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdApplicantDescription) {
return ssApplicantDescription;
}
if (key == IdDirectionId) {
return ssDirectionId;
}
if (key == IdFirstContact_EntraRoleId) {
return ssFirstContact_EntraRoleId;
}
if (key == IdSecondContact_EntraRoleId) {
return ssSecondContact_EntraRoleId;
}
if (key == IdFirstApprover_EntraRoleId) {
return ssFirstApprover_EntraRoleId;
}
if (key == IdSecondApprover_EntraRoleId) {
return ssSecondApprover_EntraRoleId;
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
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdApplicantDescription.Key.AsGuid) {
return ssApplicantDescription;
}
if (attributeKey == IdDirectionId.Key.AsGuid) {
return ssDirectionId;
}
if (attributeKey == IdFirstContact_EntraRoleId.Key.AsGuid) {
return ssFirstContact_EntraRoleId;
}
if (attributeKey == IdSecondContact_EntraRoleId.Key.AsGuid) {
return ssSecondContact_EntraRoleId;
}
if (attributeKey == IdFirstApprover_EntraRoleId.Key.AsGuid) {
return ssFirstApprover_EntraRoleId;
}
if (attributeKey == IdSecondApprover_EntraRoleId.Key.AsGuid) {
return ssSecondApprover_EntraRoleId;
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
ChangedAttributes = new BitArray(13);
OptimizedAttributes = new BitArray(13);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRegionId);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApplicant);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApplicant);
ssApplicantDescription = (string) other.AttributeGet(IdApplicantDescription);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicantDescription);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicantDescription);
ssDirectionId = (long) other.AttributeGet(IdDirectionId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdDirectionId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdDirectionId);
ssFirstContact_EntraRoleId = (long) other.AttributeGet(IdFirstContact_EntraRoleId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFirstContact_EntraRoleId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFirstContact_EntraRoleId);
ssSecondContact_EntraRoleId = (long) other.AttributeGet(IdSecondContact_EntraRoleId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdSecondContact_EntraRoleId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdSecondContact_EntraRoleId);
ssFirstApprover_EntraRoleId = (long) other.AttributeGet(IdFirstApprover_EntraRoleId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdFirstApprover_EntraRoleId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdFirstApprover_EntraRoleId);
ssSecondApprover_EntraRoleId = (long) other.AttributeGet(IdSecondApprover_EntraRoleId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdSecondApprover_EntraRoleId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdSecondApprover_EntraRoleId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[10] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[11] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[12] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_4ad0cdb13562998fda111463f2af9c31EntityRecord

/// <summary>
/// RecordList type <code>OrderDistributionConfigList</code> that represents a record list of
///  <code>OrderDistributionConfig</code>
/// </summary>
public partial class RL_9f98927ca09897763d4f4dec24a42220 : GenericRecordList<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord>, IEnumerable, IEnumerator {

protected override EN_4ad0cdb13562998fda111463f2af9c31EntityRecord GetElementDefaultValue() {
return new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();
}

public T[] ToArray<T>(Func<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f98927ca09897763d4f4dec24a42220 recordList, Func<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f98927ca09897763d4f4dec24a42220(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord[] array) {
  RL_9f98927ca09897763d4f4dec24a42220 result = new RL_9f98927ca09897763d4f4dec24a42220();
result.InnerFromArray(array);
    return result;
}

public static RL_9f98927ca09897763d4f4dec24a42220 ToList<T>(T[] array, Func <T, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> converter) {
  RL_9f98927ca09897763d4f4dec24a42220 result = new RL_9f98927ca09897763d4f4dec24a42220();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f98927ca09897763d4f4dec24a42220 FromRestList<T>(RestList<T> restList, Func <T, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> converter) {
  RL_9f98927ca09897763d4f4dec24a42220 result = new RL_9f98927ca09897763d4f4dec24a42220();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f98927ca09897763d4f4dec24a42220() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> NewList() {
return new RL_9f98927ca09897763d4f4dec24a42220();
}


} // RL_9f98927ca09897763d4f4dec24a42220
}
