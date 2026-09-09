using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Storage (U_eAn4YJskm_SJ8k0PseVg)
///  <code>EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord</code> that represents <code>Storage</code
/// > <p>Description: Storage</p>
/// </summary>
// Name: Storage
public partial struct EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord : ITypedRecord<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*KRwR97fSz0WOiL6PMXSQJw");
internal static readonly GlobalObjectKey IdConcept = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*AcG7eBhbXUyC9piMEEzcBA");
internal static readonly GlobalObjectKey IdInternalConceptId = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*kdfBH55VK0ivIQa6y3r4QA");
internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*nD4OLJ4HcEaVK80_2VnyGA");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*wyot3S5jQ0WdAZzQOeSlRQ");
internal static readonly GlobalObjectKey IdVendor = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*cuvYKpbDoEmjYjS9KXxbIQ");
internal static readonly GlobalObjectKey IdDoc_Type = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*BaSYeOStEUeKo8AXOfJNNg");
internal static readonly GlobalObjectKey IdObject_type = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*OJKDLJstvU60Q4BQGj27TA");
internal static readonly GlobalObjectKey IdIstoSendToExternal = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*2xLSDEZpPU+nrSusc0qUmw");
internal static readonly GlobalObjectKey IdWithEntegrationError = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*ayEwSS_D4kqTSc2_BTAYQg");
internal static readonly GlobalObjectKey IdIsExternal = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*j_WG9Y82LUOxhA0X0r2Row");
internal static readonly GlobalObjectKey IdArchive_ID = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*LLRSppqzmU6DVCo+Tssvxg");
internal static readonly GlobalObjectKey IdArc_Doc_ID = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*Z8zFwKEYOkqPl9LlE3TOcA");
internal static readonly GlobalObjectKey IdError_Message = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*VkPkAgRKWkGdONs8Xd+hBQ");
internal static readonly GlobalObjectKey IdSentWhen = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*O8bLv4gE+EGnL4Fn_Kv2Qg");
internal static readonly GlobalObjectKey IdIsToDelete = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*EAjgZFgBs0KVD4321nPakA");
internal static readonly GlobalObjectKey IdIsToBig = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*SQWNC6C150qOyv12xWqzcg");
internal static readonly GlobalObjectKey IdAttempt = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*bEOdGlhr8UiFC3FI3ytYrQ");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*i3VU1PrlV0i67tTDOz9i8w");
internal static readonly GlobalObjectKey IdCreateAt = GlobalObjectKey.Parse("P1c8u+QdeUmxego1hLjHsw*P2m0EL3g_UGkp6Q3HiqTog");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(20,true);
          _ssId = value;
      }
  }
}

private string _ssConcept;
public string ssConcept{
  get{
      return _ssConcept;
  }
  set{
      if((_ssConcept!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssConcept = value;
      }
  }
}

private int _ssInternalConceptId;
public int ssInternalConceptId{
  get{
      return _ssInternalConceptId;
  }
  set{
      if((_ssInternalConceptId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInternalConceptId = value;
      }
  }
}

private byte[] _ssFile;
public byte[] ssFile{
  get{
      return _ssFile;
  }
  set{
      if((_ssFile!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFile = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssVendor!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssDoc_Type!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssObject_type!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssObject_type = value;
      }
  }
}

private bool _ssIstoSendToExternal;
public bool ssIstoSendToExternal{
  get{
      return _ssIstoSendToExternal;
  }
  set{
      if((_ssIstoSendToExternal!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIstoSendToExternal = value;
      }
  }
}

private bool _ssWithEntegrationError;
public bool ssWithEntegrationError{
  get{
      return _ssWithEntegrationError;
  }
  set{
      if((_ssWithEntegrationError!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssWithEntegrationError = value;
      }
  }
}

private bool _ssIsExternal;
public bool ssIsExternal{
  get{
      return _ssIsExternal;
  }
  set{
      if((_ssIsExternal!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssIsExternal = value;
      }
  }
}

private string _ssArchive_ID;
public string ssArchive_ID{
  get{
      return _ssArchive_ID;
  }
  set{
      if((_ssArchive_ID!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssArc_Doc_ID!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssArc_Doc_ID = value;
      }
  }
}

private string _ssError_Message;
public string ssError_Message{
  get{
      return _ssError_Message;
  }
  set{
      if((_ssError_Message!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssError_Message = value;
      }
  }
}

private DateTime _ssSentWhen;
public DateTime ssSentWhen{
  get{
      return _ssSentWhen;
  }
  set{
      if((_ssSentWhen!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssSentWhen = value;
      }
  }
}

private bool _ssIsToDelete;
public bool ssIsToDelete{
  get{
      return _ssIsToDelete;
  }
  set{
      if((_ssIsToDelete!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssIsToDelete = value;
      }
  }
}

private bool _ssIsToBig;
public bool ssIsToBig{
  get{
      return _ssIsToBig;
  }
  set{
      if((_ssIsToBig!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssIsToBig = value;
      }
  }
}

private int _ssAttempt;
public int ssAttempt{
  get{
      return _ssAttempt;
  }
  set{
      if((_ssAttempt!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssAttempt = value;
      }
  }
}

private long _ssSize;
public long ssSize{
  get{
      return _ssSize;
  }
  set{
      if((_ssSize!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssSize = value;
      }
  }
}

private DateTime _ssCreateAt;
public DateTime ssCreateAt{
  get{
      return _ssCreateAt;
  }
  set{
      if((_ssCreateAt!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssCreateAt = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord() {
ChangedAttributes = new BitArray(20,true);
OptimizedAttributes = new BitArray(20,false);
_ssId = 0L;
_ssConcept = "";
_ssInternalConceptId = 0;
_ssFile = new byte[] {};
_ssFilename = "";
_ssVendor = "";
_ssDoc_Type = "";
_ssObject_type = "";
_ssIstoSendToExternal = false;
_ssWithEntegrationError = false;
_ssIsExternal = false;
_ssArchive_ID = "";
_ssArc_Doc_ID = "";
_ssError_Message = "";
_ssSentWhen = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsToDelete = false;
_ssIsToBig = false;
_ssAttempt = 1;
_ssSize = 0L;
_ssCreateAt = BuiltInFunction.CurrDate ();
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
ssId = r.ReadLongInteger(index++, "Storage.Id", 0L);
ssConcept = r.ReadText(index++, "Storage.Concept", "");
ssInternalConceptId = r.ReadEntityReference(index++, "Storage.InternalConceptId", 0);
ssFile = r.ReadBinaryData(index++, "Storage.File", new byte[] {});
ssFilename = r.ReadText(index++, "Storage.Filename", "");
ssVendor = r.ReadText(index++, "Storage.Vendor", "");
ssDoc_Type = r.ReadText(index++, "Storage.Doc_Type", "");
ssObject_type = r.ReadText(index++, "Storage.Object_type", "");
ssIstoSendToExternal = r.ReadBoolean(index++, "Storage.IstoSendToExternal", false);
ssWithEntegrationError = r.ReadBoolean(index++, "Storage.WithEntegrationError", false);
ssIsExternal = r.ReadBoolean(index++, "Storage.IsExternal", false);
ssArchive_ID = r.ReadText(index++, "Storage.Archive_ID", "");
ssArc_Doc_ID = r.ReadText(index++, "Storage.Arc_Doc_ID", "");
ssError_Message = r.ReadText(index++, "Storage.Error_Message", "");
ssSentWhen = r.ReadDateTime(index++, "Storage.SentWhen", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsToDelete = r.ReadBoolean(index++, "Storage.IsToDelete", false);
ssIsToBig = r.ReadBoolean(index++, "Storage.IsToBig", false);
ssAttempt = r.ReadInteger(index++, "Storage.Attempt", 1);
ssSize = r.ReadLongInteger(index++, "Storage.Size", 0L);
ssCreateAt = r.ReadDate(index++, "Storage.CreateAt", BuiltInFunction.CurrDate());
ChangedAttributes = new BitArray(20,false);
OptimizedAttributes = new BitArray(20,false);
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
public void ReadIM(EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord r) {
this = r;
}


public static bool operator == (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord a, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssConcept != b.ssConcept) return false;
if (a.ssInternalConceptId != b.ssInternalConceptId) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssFile, b.ssFile)) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssVendor != b.ssVendor) return false;
if (a.ssDoc_Type != b.ssDoc_Type) return false;
if (a.ssObject_type != b.ssObject_type) return false;
if (a.ssIstoSendToExternal != b.ssIstoSendToExternal) return false;
if (a.ssWithEntegrationError != b.ssWithEntegrationError) return false;
if (a.ssIsExternal != b.ssIsExternal) return false;
if (a.ssArchive_ID != b.ssArchive_ID) return false;
if (a.ssArc_Doc_ID != b.ssArc_Doc_ID) return false;
if (a.ssError_Message != b.ssError_Message) return false;
if (a.ssSentWhen != b.ssSentWhen) return false;
if (a.ssIsToDelete != b.ssIsToDelete) return false;
if (a.ssIsToBig != b.ssIsToBig) return false;
if (a.ssAttempt != b.ssAttempt) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssCreateAt != b.ssCreateAt) return false;
return true;
}

public static bool operator != (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord a, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)) return false;
return (this == (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssConcept.GetHashCode()
 ^ ssInternalConceptId.GetHashCode()
 ^ ssFile.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssVendor.GetHashCode()
 ^ ssDoc_Type.GetHashCode()
 ^ ssObject_type.GetHashCode()
 ^ ssIstoSendToExternal.GetHashCode()
 ^ ssWithEntegrationError.GetHashCode()
 ^ ssIsExternal.GetHashCode()
 ^ ssArchive_ID.GetHashCode()
 ^ ssArc_Doc_ID.GetHashCode()
 ^ ssError_Message.GetHashCode()
 ^ ssSentWhen.GetHashCode()
 ^ ssIsToDelete.GetHashCode()
 ^ ssIsToBig.GetHashCode()
 ^ ssAttempt.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssCreateAt.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord Duplicate() {
EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord t;
t._ssId = this._ssId;
t._ssConcept = this._ssConcept;
t._ssInternalConceptId = this._ssInternalConceptId;
t._ssFile = this._ssFile;
t._ssFilename = this._ssFilename;
t._ssVendor = this._ssVendor;
t._ssDoc_Type = this._ssDoc_Type;
t._ssObject_type = this._ssObject_type;
t._ssIstoSendToExternal = this._ssIstoSendToExternal;
t._ssWithEntegrationError = this._ssWithEntegrationError;
t._ssIsExternal = this._ssIsExternal;
t._ssArchive_ID = this._ssArchive_ID;
t._ssArc_Doc_ID = this._ssArc_Doc_ID;
t._ssError_Message = this._ssError_Message;
t._ssSentWhen = this._ssSentWhen;
t._ssIsToDelete = this._ssIsToDelete;
t._ssIsToBig = this._ssIsToBig;
t._ssAttempt = this._ssAttempt;
t._ssSize = this._ssSize;
t._ssCreateAt = this._ssCreateAt;
t.ChangedAttributes = new BitArray(20);
t.OptimizedAttributes = new BitArray(20);
for(int i = 0; i < 20; i++){
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
} else if (head == "concept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Concept")) variable.Value = ssConcept; else variable.Optimized = true;
} else if (head == "internalconceptid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InternalConceptId")) variable.Value = ssInternalConceptId; else variable.Optimized = true;
} else if (head == "file") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssFile; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "vendor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Vendor")) variable.Value = ssVendor; else variable.Optimized = true;
} else if (head == "doc_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Doc_Type")) variable.Value = ssDoc_Type; else variable.Optimized = true;
} else if (head == "object_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Object_type")) variable.Value = ssObject_type; else variable.Optimized = true;
} else if (head == "istosendtoexternal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IstoSendToExternal")) variable.Value = ssIstoSendToExternal; else variable.Optimized = true;
} else if (head == "withentegrationerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WithEntegrationError")) variable.Value = ssWithEntegrationError; else variable.Optimized = true;
} else if (head == "isexternal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExternal")) variable.Value = ssIsExternal; else variable.Optimized = true;
} else if (head == "archive_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Archive_ID")) variable.Value = ssArchive_ID; else variable.Optimized = true;
} else if (head == "arc_doc_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Arc_Doc_ID")) variable.Value = ssArc_Doc_ID; else variable.Optimized = true;
} else if (head == "error_message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Error_Message")) variable.Value = ssError_Message; else variable.Optimized = true;
} else if (head == "sentwhen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SentWhen")) variable.Value = ssSentWhen; else variable.Optimized = true;
} else if (head == "istodelete") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsToDelete")) variable.Value = ssIsToDelete; else variable.Optimized = true;
} else if (head == "istobig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsToBig")) variable.Value = ssIsToBig; else variable.Optimized = true;
} else if (head == "attempt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Attempt")) variable.Value = ssAttempt; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "createat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreateAt")) variable.Value = ssCreateAt; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdConcept)) {
return ChangedAttributes[1];
}
if (key.Equals(IdInternalConceptId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFile)) {
return ChangedAttributes[3];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[4];
}
if (key.Equals(IdVendor)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDoc_Type)) {
return ChangedAttributes[6];
}
if (key.Equals(IdObject_type)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIstoSendToExternal)) {
return ChangedAttributes[8];
}
if (key.Equals(IdWithEntegrationError)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIsExternal)) {
return ChangedAttributes[10];
}
if (key.Equals(IdArchive_ID)) {
return ChangedAttributes[11];
}
if (key.Equals(IdArc_Doc_ID)) {
return ChangedAttributes[12];
}
if (key.Equals(IdError_Message)) {
return ChangedAttributes[13];
}
if (key.Equals(IdSentWhen)) {
return ChangedAttributes[14];
}
if (key.Equals(IdIsToDelete)) {
return ChangedAttributes[15];
}
if (key.Equals(IdIsToBig)) {
return ChangedAttributes[16];
}
if (key.Equals(IdAttempt)) {
return ChangedAttributes[17];
}
if (key.Equals(IdSize)) {
return ChangedAttributes[18];
}
if (key.Equals(IdCreateAt)) {
return ChangedAttributes[19];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdConcept)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdInternalConceptId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFile)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdVendor)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDoc_Type)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdObject_type)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIstoSendToExternal)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdWithEntegrationError)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIsExternal)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdArchive_ID)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdArc_Doc_ID)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdError_Message)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdSentWhen)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdIsToDelete)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdIsToBig)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdAttempt)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdSize)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdCreateAt)) {
return OptimizedAttributes[19];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdConcept) {
return ssConcept;
}
if (key == IdInternalConceptId) {
return ssInternalConceptId;
}
if (key == IdFile) {
return ssFile;
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
if (key == IdIstoSendToExternal) {
return ssIstoSendToExternal;
}
if (key == IdWithEntegrationError) {
return ssWithEntegrationError;
}
if (key == IdIsExternal) {
return ssIsExternal;
}
if (key == IdArchive_ID) {
return ssArchive_ID;
}
if (key == IdArc_Doc_ID) {
return ssArc_Doc_ID;
}
if (key == IdError_Message) {
return ssError_Message;
}
if (key == IdSentWhen) {
return ssSentWhen;
}
if (key == IdIsToDelete) {
return ssIsToDelete;
}
if (key == IdIsToBig) {
return ssIsToBig;
}
if (key == IdAttempt) {
return ssAttempt;
}
if (key == IdSize) {
return ssSize;
}
if (key == IdCreateAt) {
return ssCreateAt;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdConcept.Key.AsGuid) {
return ssConcept;
}
if (attributeKey == IdInternalConceptId.Key.AsGuid) {
return ssInternalConceptId;
}
if (attributeKey == IdFile.Key.AsGuid) {
return ssFile;
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
if (attributeKey == IdIstoSendToExternal.Key.AsGuid) {
return ssIstoSendToExternal;
}
if (attributeKey == IdWithEntegrationError.Key.AsGuid) {
return ssWithEntegrationError;
}
if (attributeKey == IdIsExternal.Key.AsGuid) {
return ssIsExternal;
}
if (attributeKey == IdArchive_ID.Key.AsGuid) {
return ssArchive_ID;
}
if (attributeKey == IdArc_Doc_ID.Key.AsGuid) {
return ssArc_Doc_ID;
}
if (attributeKey == IdError_Message.Key.AsGuid) {
return ssError_Message;
}
if (attributeKey == IdSentWhen.Key.AsGuid) {
return ssSentWhen;
}
if (attributeKey == IdIsToDelete.Key.AsGuid) {
return ssIsToDelete;
}
if (attributeKey == IdIsToBig.Key.AsGuid) {
return ssIsToBig;
}
if (attributeKey == IdAttempt.Key.AsGuid) {
return ssAttempt;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdCreateAt.Key.AsGuid) {
return ssCreateAt;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(20);
OptimizedAttributes = new BitArray(20);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssConcept = (string) other.AttributeGet(IdConcept);
ChangedAttributes[1] = other.ChangedAttributeGet(IdConcept);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdConcept);
ssInternalConceptId = (int) other.AttributeGet(IdInternalConceptId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInternalConceptId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInternalConceptId);
ssFile = (byte[]) other.AttributeGet(IdFile);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFile);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFile);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[4] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFilename);
ssVendor = (string) other.AttributeGet(IdVendor);
ChangedAttributes[5] = other.ChangedAttributeGet(IdVendor);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdVendor);
ssDoc_Type = (string) other.AttributeGet(IdDoc_Type);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDoc_Type);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDoc_Type);
ssObject_type = (string) other.AttributeGet(IdObject_type);
ChangedAttributes[7] = other.ChangedAttributeGet(IdObject_type);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdObject_type);
ssIstoSendToExternal = (bool) other.AttributeGet(IdIstoSendToExternal);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIstoSendToExternal);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIstoSendToExternal);
ssWithEntegrationError = (bool) other.AttributeGet(IdWithEntegrationError);
ChangedAttributes[9] = other.ChangedAttributeGet(IdWithEntegrationError);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdWithEntegrationError);
ssIsExternal = (bool) other.AttributeGet(IdIsExternal);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIsExternal);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIsExternal);
ssArchive_ID = (string) other.AttributeGet(IdArchive_ID);
ChangedAttributes[11] = other.ChangedAttributeGet(IdArchive_ID);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdArchive_ID);
ssArc_Doc_ID = (string) other.AttributeGet(IdArc_Doc_ID);
ChangedAttributes[12] = other.ChangedAttributeGet(IdArc_Doc_ID);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdArc_Doc_ID);
ssError_Message = (string) other.AttributeGet(IdError_Message);
ChangedAttributes[13] = other.ChangedAttributeGet(IdError_Message);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdError_Message);
ssSentWhen = (DateTime) other.AttributeGet(IdSentWhen);
ChangedAttributes[14] = other.ChangedAttributeGet(IdSentWhen);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdSentWhen);
ssIsToDelete = (bool) other.AttributeGet(IdIsToDelete);
ChangedAttributes[15] = other.ChangedAttributeGet(IdIsToDelete);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdIsToDelete);
ssIsToBig = (bool) other.AttributeGet(IdIsToBig);
ChangedAttributes[16] = other.ChangedAttributeGet(IdIsToBig);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdIsToBig);
ssAttempt = (int) other.AttributeGet(IdAttempt);
ChangedAttributes[17] = other.ChangedAttributeGet(IdAttempt);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdAttempt);
ssSize = (long) other.AttributeGet(IdSize);
ChangedAttributes[18] = other.ChangedAttributeGet(IdSize);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdSize);
ssCreateAt = (DateTime) other.AttributeGet(IdCreateAt);
ChangedAttributes[19] = other.ChangedAttributeGet(IdCreateAt);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdCreateAt);
}
} // EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord

/// <summary>
/// RecordList type <code>StorageList</code> that represents a record list of <code>Storage</code>
/// </summary>
public partial class RL_b8e07b1713b302ce457c8c2a24654733 : GenericRecordList<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord>, IEnumerable, IEnumerator {

protected override EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord GetElementDefaultValue() {
return new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public T[] ToArray<T>(Func<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b8e07b1713b302ce457c8c2a24654733 recordList, Func<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b8e07b1713b302ce457c8c2a24654733(EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord[] array) {
  RL_b8e07b1713b302ce457c8c2a24654733 result = new RL_b8e07b1713b302ce457c8c2a24654733();
result.InnerFromArray(array);
    return result;
}

public static RL_b8e07b1713b302ce457c8c2a24654733 ToList<T>(T[] array, Func <T, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> converter) {
  RL_b8e07b1713b302ce457c8c2a24654733 result = new RL_b8e07b1713b302ce457c8c2a24654733();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b8e07b1713b302ce457c8c2a24654733 FromRestList<T>(RestList<T> restList, Func <T, EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> converter) {
  RL_b8e07b1713b302ce457c8c2a24654733 result = new RL_b8e07b1713b302ce457c8c2a24654733();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b8e07b1713b302ce457c8c2a24654733() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord> NewList() {
return new RL_b8e07b1713b302ce457c8c2a24654733();
}


} // RL_b8e07b1713b302ce457c8c2a24654733
}
