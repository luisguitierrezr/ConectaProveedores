using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] DeletedStorage (sDMThXAu00azYiGHU0zH+w)
///  <code>EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord</code> that represent
/// s <code>DeletedStorage</code> <p>Description: Deleted Storage</p>
/// </summary>
// Name: DeletedStorage
public partial struct EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord : ITypedRecord<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*z5Oha8sT0kaDdexHlxSFpQ");
internal static readonly GlobalObjectKey IdInternalConceptId = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*yy7A5rei2EaWQ7xA6aKlCg");
internal static readonly GlobalObjectKey IdConcept = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*gMCTvJJPjUqjz9J6GvHnfQ");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*kdChdz_I9U6NbAN9dmLdvw");
internal static readonly GlobalObjectKey IdVendor = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*uUOwRSHCE06QxXJAPB3CVg");
internal static readonly GlobalObjectKey IdDoc_Type = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*IA+5TRndNE2vWOfVSSrP+A");
internal static readonly GlobalObjectKey IdObject_type = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*2RLmttMuRk6W3dwTfD0y4g");
internal static readonly GlobalObjectKey IdArchive_ID = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*1Qd1s_Q140uEh7przob6VA");
internal static readonly GlobalObjectKey IdArc_Doc_ID = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*bCDUGoEJjkuLwacOK9AvOw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
          _ssId = value;
      }
  }
}

private int _ssInternalConceptId;
public int ssInternalConceptId{
  get{
      return _ssInternalConceptId;
  }
  set{
      if((_ssInternalConceptId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInternalConceptId = value;
      }
  }
}

private string _ssConcept;
public string ssConcept{
  get{
      return _ssConcept;
  }
  set{
      if((_ssConcept!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssConcept = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFilename = value;
      }
  }
}

private string _ssVendor;
public string ssVendor{
  get{
      return _ssVendor;
  }
  set{
      if((_ssVendor!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssVendor = value;
      }
  }
}

private string _ssDoc_Type;
public string ssDoc_Type{
  get{
      return _ssDoc_Type;
  }
  set{
      if((_ssDoc_Type!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDoc_Type = value;
      }
  }
}

private string _ssObject_type;
public string ssObject_type{
  get{
      return _ssObject_type;
  }
  set{
      if((_ssObject_type!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssObject_type = value;
      }
  }
}

private string _ssArchive_ID;
public string ssArchive_ID{
  get{
      return _ssArchive_ID;
  }
  set{
      if((_ssArchive_ID!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssArchive_ID = value;
      }
  }
}

private string _ssArc_Doc_ID;
public string ssArc_Doc_ID{
  get{
      return _ssArc_Doc_ID;
  }
  set{
      if((_ssArc_Doc_ID!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssArc_Doc_ID = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssInternalConceptId = 0;
_ssConcept = "";
_ssFilename = "";
_ssVendor = "";
_ssDoc_Type = "";
_ssObject_type = "";
_ssArchive_ID = "";
_ssArc_Doc_ID = "";
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
ssId = r.ReadLongInteger(index++, "DeletedStorage.Id", 0L);
ssInternalConceptId = r.ReadEntityReference(index++, "DeletedStorage.InternalConceptId", 0);
ssConcept = r.ReadText(index++, "DeletedStorage.Concept", "");
ssFilename = r.ReadText(index++, "DeletedStorage.Filename", "");
ssVendor = r.ReadText(index++, "DeletedStorage.Vendor", "");
ssDoc_Type = r.ReadText(index++, "DeletedStorage.Doc_Type", "");
ssObject_type = r.ReadText(index++, "DeletedStorage.Object_type", "");
ssArchive_ID = r.ReadText(index++, "DeletedStorage.Archive_ID", "");
ssArc_Doc_ID = r.ReadText(index++, "DeletedStorage.Arc_Doc_ID", "");
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord r) {
this = r;
}


public static bool operator == (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord a, EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInternalConceptId != b.ssInternalConceptId) return false;
if (a.ssConcept != b.ssConcept) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssVendor != b.ssVendor) return false;
if (a.ssDoc_Type != b.ssDoc_Type) return false;
if (a.ssObject_type != b.ssObject_type) return false;
if (a.ssArchive_ID != b.ssArchive_ID) return false;
if (a.ssArc_Doc_ID != b.ssArc_Doc_ID) return false;
return true;
}

public static bool operator != (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord a, EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord)) return false;
return (this == (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInternalConceptId.GetHashCode()
 ^ ssConcept.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssVendor.GetHashCode()
 ^ ssDoc_Type.GetHashCode()
 ^ ssObject_type.GetHashCode()
 ^ ssArchive_ID.GetHashCode()
 ^ ssArc_Doc_ID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord Duplicate() {
EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord t;
t._ssId = this._ssId;
t._ssInternalConceptId = this._ssInternalConceptId;
t._ssConcept = this._ssConcept;
t._ssFilename = this._ssFilename;
t._ssVendor = this._ssVendor;
t._ssDoc_Type = this._ssDoc_Type;
t._ssObject_type = this._ssObject_type;
t._ssArchive_ID = this._ssArchive_ID;
t._ssArc_Doc_ID = this._ssArc_Doc_ID;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "internalconceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InternalConceptId")) variable.Value = ssInternalConceptId; else variable.Optimized = true;
} else if (head == "concept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Concept")) variable.Value = ssConcept; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "vendor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Vendor")) variable.Value = ssVendor; else variable.Optimized = true;
} else if (head == "doc_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Doc_Type")) variable.Value = ssDoc_Type; else variable.Optimized = true;
} else if (head == "object_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Object_type")) variable.Value = ssObject_type; else variable.Optimized = true;
} else if (head == "archive_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Archive_ID")) variable.Value = ssArchive_ID; else variable.Optimized = true;
} else if (head == "arc_doc_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Arc_Doc_ID")) variable.Value = ssArc_Doc_ID; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInternalConceptId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdConcept)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[3];
}
if (key.Equals(IdVendor)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDoc_Type)) {
return ChangedAttributes[5];
}
if (key.Equals(IdObject_type)) {
return ChangedAttributes[6];
}
if (key.Equals(IdArchive_ID)) {
return ChangedAttributes[7];
}
if (key.Equals(IdArc_Doc_ID)) {
return ChangedAttributes[8];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInternalConceptId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdConcept)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdVendor)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDoc_Type)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdObject_type)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdArchive_ID)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdArc_Doc_ID)) {
return OptimizedAttributes[8];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInternalConceptId) {
return ssInternalConceptId;
}
if (key == IdConcept) {
return ssConcept;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdVendor) {
return ssVendor;
}
if (key == IdDoc_Type) {
return ssDoc_Type;
}
if (key == IdObject_type) {
return ssObject_type;
}
if (key == IdArchive_ID) {
return ssArchive_ID;
}
if (key == IdArc_Doc_ID) {
return ssArc_Doc_ID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInternalConceptId.Key.AsGuid) {
return ssInternalConceptId;
}
if (attributeKey == IdConcept.Key.AsGuid) {
return ssConcept;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdVendor.Key.AsGuid) {
return ssVendor;
}
if (attributeKey == IdDoc_Type.Key.AsGuid) {
return ssDoc_Type;
}
if (attributeKey == IdObject_type.Key.AsGuid) {
return ssObject_type;
}
if (attributeKey == IdArchive_ID.Key.AsGuid) {
return ssArchive_ID;
}
if (attributeKey == IdArc_Doc_ID.Key.AsGuid) {
return ssArc_Doc_ID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInternalConceptId = (int) other.AttributeGet(IdInternalConceptId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInternalConceptId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInternalConceptId);
ssConcept = (string) other.AttributeGet(IdConcept);
ChangedAttributes[2] = other.ChangedAttributeGet(IdConcept);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdConcept);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFilename);
ssVendor = (string) other.AttributeGet(IdVendor);
ChangedAttributes[4] = other.ChangedAttributeGet(IdVendor);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdVendor);
ssDoc_Type = (string) other.AttributeGet(IdDoc_Type);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDoc_Type);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDoc_Type);
ssObject_type = (string) other.AttributeGet(IdObject_type);
ChangedAttributes[6] = other.ChangedAttributeGet(IdObject_type);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdObject_type);
ssArchive_ID = (string) other.AttributeGet(IdArchive_ID);
ChangedAttributes[7] = other.ChangedAttributeGet(IdArchive_ID);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdArchive_ID);
ssArc_Doc_ID = (string) other.AttributeGet(IdArc_Doc_ID);
ChangedAttributes[8] = other.ChangedAttributeGet(IdArc_Doc_ID);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdArc_Doc_ID);
}
} // EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord

/// <summary>
/// RecordList type <code>DeletedStorageList</code> that represents a record list of
///  <code>DeletedStorage</code>
/// </summary>
public partial class RL_a5ae7785649ec4ca26131f932d37becd : GenericRecordList<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord>, IEnumerable, IEnumerator {

protected override EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord GetElementDefaultValue() {
return new EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord();
}

public T[] ToArray<T>(Func<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a5ae7785649ec4ca26131f932d37becd recordList, Func<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a5ae7785649ec4ca26131f932d37becd(EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord[] array) {
  RL_a5ae7785649ec4ca26131f932d37becd result = new RL_a5ae7785649ec4ca26131f932d37becd();
result.InnerFromArray(array);
    return result;
}

public static RL_a5ae7785649ec4ca26131f932d37becd ToList<T>(T[] array, Func <T, EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> converter) {
  RL_a5ae7785649ec4ca26131f932d37becd result = new RL_a5ae7785649ec4ca26131f932d37becd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a5ae7785649ec4ca26131f932d37becd FromRestList<T>(RestList<T> restList, Func <T, EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> converter) {
  RL_a5ae7785649ec4ca26131f932d37becd result = new RL_a5ae7785649ec4ca26131f932d37becd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a5ae7785649ec4ca26131f932d37becd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord> NewList() {
return new RL_a5ae7785649ec4ca26131f932d37becd();
}


} // RL_a5ae7785649ec4ca26131f932d37becd
}
