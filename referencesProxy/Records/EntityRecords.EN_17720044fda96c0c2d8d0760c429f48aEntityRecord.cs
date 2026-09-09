using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] PaymentTerms (EljJDkDm00aWN75JnCsmOg)
///  <code>EN_17720044fda96c0c2d8d0760c429f48aEntityRecord</code> that represent
/// s <code>PaymentTerms</code> <p>Description: Entity holds Payments Terms. Vías de Pago.</p>
/// </summary>
// Name: PaymentTerms
public partial struct EN_17720044fda96c0c2d8d0760c429f48aEntityRecord : ITypedRecord<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ryvPfp5JHUS5G9KMaxkfTQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*BN8SMfoSYEK3oynAYh0e2w");
internal static readonly GlobalObjectKey IdClCta = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1pxbd9riskOg_WsxwNVTZg");
internal static readonly GlobalObjectKey IdClassFecha = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*_Ij6hu8tnkO10UpwAmiixA");
internal static readonly GlobalObjectKey IdCtd_dias = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*hC+_Ri6Ii0u8FNlLAyd1lg");
internal static readonly GlobalObjectKey IdEstructuraDescripcionPROP = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*O_puoIM7UkyTvW4qmjEffw");
internal static readonly GlobalObjectKey IdIsSpecial = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VNE72GGY60+hlR9Zfcn4Fw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*85GloPZU0EW3oIIRVTRyTA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wSC0JUiDtES6oFe1ed4sWA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*oYp10vVlrU2q_0BpBl6Y4A");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*fUeTIhzueUiO2v_i+RihXw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(11,true);
          _ssId = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssDescription = value;
      }
  }
}

private string _ssClCta;
public string ssClCta{
  get{
      return _ssClCta;
  }
  set{
      if((_ssClCta!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssClCta = value;
      }
  }
}

private string _ssClassFecha;
public string ssClassFecha{
  get{
      return _ssClassFecha;
  }
  set{
      if((_ssClassFecha!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssClassFecha = value;
      }
  }
}

private string _ssCtd_dias;
public string ssCtd_dias{
  get{
      return _ssCtd_dias;
  }
  set{
      if((_ssCtd_dias!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCtd_dias = value;
      }
  }
}

private string _ssEstructuraDescripcionPROP;
public string ssEstructuraDescripcionPROP{
  get{
      return _ssEstructuraDescripcionPROP;
  }
  set{
      if((_ssEstructuraDescripcionPROP!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssEstructuraDescripcionPROP = value;
      }
  }
}

private bool _ssIsSpecial;
public bool ssIsSpecial{
  get{
      return _ssIsSpecial;
  }
  set{
      if((_ssIsSpecial!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsSpecial = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord() {
ChangedAttributes = new BitArray(11,true);
OptimizedAttributes = new BitArray(11,false);
_ssId = 0L;
_ssDescription = "";
_ssClCta = "";
_ssClassFecha = "";
_ssCtd_dias = "";
_ssEstructuraDescripcionPROP = "";
_ssIsSpecial = false;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "PaymentTerms.Id", 0L);
ssDescription = r.ReadText(index++, "PaymentTerms.Description", "");
ssClCta = r.ReadText(index++, "PaymentTerms.ClCta", "");
ssClassFecha = r.ReadText(index++, "PaymentTerms.ClassFecha", "");
ssCtd_dias = r.ReadText(index++, "PaymentTerms.Ctd_dias", "");
ssEstructuraDescripcionPROP = r.ReadText(index++, "PaymentTerms.EstructuraDescripcionPROP", "");
ssIsSpecial = r.ReadBoolean(index++, "PaymentTerms.IsSpecial", false);
ssCreatedOn = r.ReadDateTime(index++, "PaymentTerms.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "PaymentTerms.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "PaymentTerms.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "PaymentTerms.UpdatedBy", "");
ChangedAttributes = new BitArray(11,false);
OptimizedAttributes = new BitArray(11,false);
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
public void ReadIM(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord r) {
this = r;
}


public static bool operator == (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord a, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssClCta != b.ssClCta) return false;
if (a.ssClassFecha != b.ssClassFecha) return false;
if (a.ssCtd_dias != b.ssCtd_dias) return false;
if (a.ssEstructuraDescripcionPROP != b.ssEstructuraDescripcionPROP) return false;
if (a.ssIsSpecial != b.ssIsSpecial) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord a, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)) return false;
return (this == (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssClCta.GetHashCode()
 ^ ssClassFecha.GetHashCode()
 ^ ssCtd_dias.GetHashCode()
 ^ ssEstructuraDescripcionPROP.GetHashCode()
 ^ ssIsSpecial.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord Duplicate() {
EN_17720044fda96c0c2d8d0760c429f48aEntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssClCta = this._ssClCta;
t._ssClassFecha = this._ssClassFecha;
t._ssCtd_dias = this._ssCtd_dias;
t._ssEstructuraDescripcionPROP = this._ssEstructuraDescripcionPROP;
t._ssIsSpecial = this._ssIsSpecial;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(11);
t.OptimizedAttributes = new BitArray(11);
for(int i = 0; i < 11; i++){
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
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "clcta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ClCta")) variable.Value = ssClCta; else variable.Optimized = true;
} else if (head == "classfecha") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ClassFecha")) variable.Value = ssClassFecha; else variable.Optimized = true;
} else if (head == "ctd_dias") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ctd_dias")) variable.Value = ssCtd_dias; else variable.Optimized = true;
} else if (head == "estructuradescripcionprop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EstructuraDescripcionPROP")) variable.Value = ssEstructuraDescripcionPROP; else variable.Optimized = true;
} else if (head == "isspecial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSpecial")) variable.Value = ssIsSpecial; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[1];
}
if (key.Equals(IdClCta)) {
return ChangedAttributes[2];
}
if (key.Equals(IdClassFecha)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCtd_dias)) {
return ChangedAttributes[4];
}
if (key.Equals(IdEstructuraDescripcionPROP)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsSpecial)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[10];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdClCta)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdClassFecha)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCtd_dias)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdEstructuraDescripcionPROP)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsSpecial)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[10];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdClCta) {
return ssClCta;
}
if (key == IdClassFecha) {
return ssClassFecha;
}
if (key == IdCtd_dias) {
return ssCtd_dias;
}
if (key == IdEstructuraDescripcionPROP) {
return ssEstructuraDescripcionPROP;
}
if (key == IdIsSpecial) {
return ssIsSpecial;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdClCta.Key.AsGuid) {
return ssClCta;
}
if (attributeKey == IdClassFecha.Key.AsGuid) {
return ssClassFecha;
}
if (attributeKey == IdCtd_dias.Key.AsGuid) {
return ssCtd_dias;
}
if (attributeKey == IdEstructuraDescripcionPROP.Key.AsGuid) {
return ssEstructuraDescripcionPROP;
}
if (attributeKey == IdIsSpecial.Key.AsGuid) {
return ssIsSpecial;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(11);
OptimizedAttributes = new BitArray(11);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssClCta = (string) other.AttributeGet(IdClCta);
ChangedAttributes[2] = other.ChangedAttributeGet(IdClCta);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdClCta);
ssClassFecha = (string) other.AttributeGet(IdClassFecha);
ChangedAttributes[3] = other.ChangedAttributeGet(IdClassFecha);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdClassFecha);
ssCtd_dias = (string) other.AttributeGet(IdCtd_dias);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCtd_dias);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCtd_dias);
ssEstructuraDescripcionPROP = (string) other.AttributeGet(IdEstructuraDescripcionPROP);
ChangedAttributes[5] = other.ChangedAttributeGet(IdEstructuraDescripcionPROP);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdEstructuraDescripcionPROP);
ssIsSpecial = (bool) other.AttributeGet(IdIsSpecial);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsSpecial);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsSpecial);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_17720044fda96c0c2d8d0760c429f48aEntityRecord

/// <summary>
/// RecordList type <code>PaymentTermsList</code> that represents a record list of
///  <code>PaymentTerms</code>
/// </summary>
public partial class RL_53f965443c41847c451871a6b3bcf2a0 : GenericRecordList<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_17720044fda96c0c2d8d0760c429f48aEntityRecord GetElementDefaultValue() {
return new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public T[] ToArray<T>(Func<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_53f965443c41847c451871a6b3bcf2a0 recordList, Func<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_53f965443c41847c451871a6b3bcf2a0(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord[] array) {
  RL_53f965443c41847c451871a6b3bcf2a0 result = new RL_53f965443c41847c451871a6b3bcf2a0();
result.InnerFromArray(array);
    return result;
}

public static RL_53f965443c41847c451871a6b3bcf2a0 ToList<T>(T[] array, Func <T, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> converter) {
  RL_53f965443c41847c451871a6b3bcf2a0 result = new RL_53f965443c41847c451871a6b3bcf2a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_53f965443c41847c451871a6b3bcf2a0 FromRestList<T>(RestList<T> restList, Func <T, EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> converter) {
  RL_53f965443c41847c451871a6b3bcf2a0 result = new RL_53f965443c41847c451871a6b3bcf2a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_53f965443c41847c451871a6b3bcf2a0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_17720044fda96c0c2d8d0760c429f48aEntityRecord> NewList() {
return new RL_53f965443c41847c451871a6b3bcf2a0();
}


} // RL_53f965443c41847c451871a6b3bcf2a0
}
