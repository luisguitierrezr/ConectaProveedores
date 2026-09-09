using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Audit (yQWdh5rsYEixlL2jMr4aRg)
///  <code>EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord</code> that represents <code>Audit</code
/// > <p>Description: Audit</p>
/// </summary>
// Name: Audit
public partial struct EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord : ITypedRecord<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*4UqGdhZiak+etIfHQcUUQQ");
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*7NxNUL6ldUCk3Sjwzt4PAw");
internal static readonly GlobalObjectKey IdIdentifier = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*BKnubMLjCUWaI1eI6XUszA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*cY3B9opVKkOjxVx1YjIabw");
internal static readonly GlobalObjectKey IdScreen = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*gdvoToDZYUa0LmBYEtuLpw");
internal static readonly GlobalObjectKey IdFunctionality = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*94cJ1wDPckmAerYqrEO5JQ");
internal static readonly GlobalObjectKey IdOriginalJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*X1dxpkJQtUCboc+Vpl2oWQ");
internal static readonly GlobalObjectKey IdChangeJSON = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*WDZOtaa30kCKuzzAm6yiqg");
internal static readonly GlobalObjectKey IdOccurrenceDateTime = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*IvmKk2HneECnRbxDx_Usrw");
internal static readonly GlobalObjectKey IdOccurrenceUser = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*qF0cfDRPLEmiYIINtvwxJw");
internal static readonly GlobalObjectKey IdOccurrenceRoleName = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*qz0LwtjLbk6jSs3Sja8v8w");
internal static readonly GlobalObjectKey IdAccessIP = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*O8Q6JkE9e0m8igCie8vb9g");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("mmiiin9toUWcWlIGpp+Idw*gESgfOHOcEOsPq+evuBkkg");

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

private int _ssOrigin;
public int ssOrigin{
  get{
      return _ssOrigin;
  }
  set{
      if((_ssOrigin!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrigin = value;
      }
  }
}

private long _ssIdentifier;
public long ssIdentifier{
  get{
      return _ssIdentifier;
  }
  set{
      if((_ssIdentifier!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssIdentifier = value;
      }
  }
}

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMessage = value;
      }
  }
}

private string _ssScreen;
public string ssScreen{
  get{
      return _ssScreen;
  }
  set{
      if((_ssScreen!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssScreen = value;
      }
  }
}

private string _ssFunctionality;
public string ssFunctionality{
  get{
      return _ssFunctionality;
  }
  set{
      if((_ssFunctionality!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFunctionality = value;
      }
  }
}

private string _ssOriginalJSON;
public string ssOriginalJSON{
  get{
      return _ssOriginalJSON;
  }
  set{
      if((_ssOriginalJSON!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssOriginalJSON = value;
      }
  }
}

private string _ssChangeJSON;
public string ssChangeJSON{
  get{
      return _ssChangeJSON;
  }
  set{
      if((_ssChangeJSON!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssChangeJSON = value;
      }
  }
}

private DateTime _ssOccurrenceDateTime;
public DateTime ssOccurrenceDateTime{
  get{
      return _ssOccurrenceDateTime;
  }
  set{
      if((_ssOccurrenceDateTime!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssOccurrenceDateTime = value;
      }
  }
}

private string _ssOccurrenceUser;
public string ssOccurrenceUser{
  get{
      return _ssOccurrenceUser;
  }
  set{
      if((_ssOccurrenceUser!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssOccurrenceUser = value;
      }
  }
}

private string _ssOccurrenceRoleName;
public string ssOccurrenceRoleName{
  get{
      return _ssOccurrenceRoleName;
  }
  set{
      if((_ssOccurrenceRoleName!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssOccurrenceRoleName = value;
      }
  }
}

private string _ssAccessIP;
public string ssAccessIP{
  get{
      return _ssAccessIP;
  }
  set{
      if((_ssAccessIP!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssAccessIP = value;
      }
  }
}

private bool _ssIsError;
public bool ssIsError{
  get{
      return _ssIsError;
  }
  set{
      if((_ssIsError!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssIsError = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord() {
ChangedAttributes = new BitArray(13,true);
OptimizedAttributes = new BitArray(13,false);
_ssId = 0L;
_ssOrigin = 0;
_ssIdentifier = 0L;
_ssMessage = "";
_ssScreen = "";
_ssFunctionality = "";
_ssOriginalJSON = "";
_ssChangeJSON = "";
_ssOccurrenceDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssOccurrenceUser = "";
_ssOccurrenceRoleName = "";
_ssAccessIP = "";
_ssIsError = false;
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
ssId = r.ReadLongInteger(index++, "Audit.Id", 0L);
ssOrigin = r.ReadEntityReference(index++, "Audit.Origin", 0);
ssIdentifier = r.ReadLongInteger(index++, "Audit.Identifier", 0L);
ssMessage = r.ReadText(index++, "Audit.Message", "");
ssScreen = r.ReadText(index++, "Audit.Screen", "");
ssFunctionality = r.ReadText(index++, "Audit.Functionality", "");
ssOriginalJSON = r.ReadText(index++, "Audit.OriginalJSON", "");
ssChangeJSON = r.ReadText(index++, "Audit.ChangeJSON", "");
ssOccurrenceDateTime = r.ReadDateTime(index++, "Audit.OccurrenceDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOccurrenceUser = r.ReadEntityReferenceText(index++, "Audit.OccurrenceUser", "");
ssOccurrenceRoleName = r.ReadText(index++, "Audit.OccurrenceRoleName", "");
ssAccessIP = r.ReadText(index++, "Audit.AccessIP", "");
ssIsError = r.ReadBoolean(index++, "Audit.IsError", false);
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
public void ReadIM(EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord r) {
this = r;
}


public static bool operator == (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord a, EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrigin != b.ssOrigin) return false;
if (a.ssIdentifier != b.ssIdentifier) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssScreen != b.ssScreen) return false;
if (a.ssFunctionality != b.ssFunctionality) return false;
if (a.ssOriginalJSON != b.ssOriginalJSON) return false;
if (a.ssChangeJSON != b.ssChangeJSON) return false;
if (a.ssOccurrenceDateTime != b.ssOccurrenceDateTime) return false;
if (a.ssOccurrenceUser != b.ssOccurrenceUser) return false;
if (a.ssOccurrenceRoleName != b.ssOccurrenceRoleName) return false;
if (a.ssAccessIP != b.ssAccessIP) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord a, EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord)) return false;
return (this == (EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrigin.GetHashCode()
 ^ ssIdentifier.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssScreen.GetHashCode()
 ^ ssFunctionality.GetHashCode()
 ^ ssOriginalJSON.GetHashCode()
 ^ ssChangeJSON.GetHashCode()
 ^ ssOccurrenceDateTime.GetHashCode()
 ^ ssOccurrenceUser.GetHashCode()
 ^ ssOccurrenceRoleName.GetHashCode()
 ^ ssAccessIP.GetHashCode()
 ^ ssIsError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord Duplicate() {
EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord t;
t._ssId = this._ssId;
t._ssOrigin = this._ssOrigin;
t._ssIdentifier = this._ssIdentifier;
t._ssMessage = this._ssMessage;
t._ssScreen = this._ssScreen;
t._ssFunctionality = this._ssFunctionality;
t._ssOriginalJSON = this._ssOriginalJSON;
t._ssChangeJSON = this._ssChangeJSON;
t._ssOccurrenceDateTime = this._ssOccurrenceDateTime;
t._ssOccurrenceUser = this._ssOccurrenceUser;
t._ssOccurrenceRoleName = this._ssOccurrenceRoleName;
t._ssAccessIP = this._ssAccessIP;
t._ssIsError = this._ssIsError;
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
} else if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssOrigin; else variable.Optimized = true;
} else if (head == "identifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Identifier")) variable.Value = ssIdentifier; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "screen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Screen")) variable.Value = ssScreen; else variable.Optimized = true;
} else if (head == "functionality") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Functionality")) variable.Value = ssFunctionality; else variable.Optimized = true;
} else if (head == "originaljson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OriginalJSON")) variable.Value = ssOriginalJSON; else variable.Optimized = true;
} else if (head == "changejson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangeJSON")) variable.Value = ssChangeJSON; else variable.Optimized = true;
} else if (head == "occurrencedatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceDateTime")) variable.Value = ssOccurrenceDateTime; else variable.Optimized = true;
} else if (head == "occurrenceuser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceUser")) variable.Value = ssOccurrenceUser; else variable.Optimized = true;
} else if (head == "occurrencerolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OccurrenceRoleName")) variable.Value = ssOccurrenceRoleName; else variable.Optimized = true;
} else if (head == "accessip") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccessIP")) variable.Value = ssAccessIP; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrigin)) {
return ChangedAttributes[1];
}
if (key.Equals(IdIdentifier)) {
return ChangedAttributes[2];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[3];
}
if (key.Equals(IdScreen)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFunctionality)) {
return ChangedAttributes[5];
}
if (key.Equals(IdOriginalJSON)) {
return ChangedAttributes[6];
}
if (key.Equals(IdChangeJSON)) {
return ChangedAttributes[7];
}
if (key.Equals(IdOccurrenceDateTime)) {
return ChangedAttributes[8];
}
if (key.Equals(IdOccurrenceUser)) {
return ChangedAttributes[9];
}
if (key.Equals(IdOccurrenceRoleName)) {
return ChangedAttributes[10];
}
if (key.Equals(IdAccessIP)) {
return ChangedAttributes[11];
}
if (key.Equals(IdIsError)) {
return ChangedAttributes[12];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrigin)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdIdentifier)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdScreen)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFunctionality)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdOriginalJSON)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdChangeJSON)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdOccurrenceDateTime)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdOccurrenceUser)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdOccurrenceRoleName)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdAccessIP)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdIsError)) {
return OptimizedAttributes[12];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrigin) {
return ssOrigin;
}
if (key == IdIdentifier) {
return ssIdentifier;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdScreen) {
return ssScreen;
}
if (key == IdFunctionality) {
return ssFunctionality;
}
if (key == IdOriginalJSON) {
return ssOriginalJSON;
}
if (key == IdChangeJSON) {
return ssChangeJSON;
}
if (key == IdOccurrenceDateTime) {
return ssOccurrenceDateTime;
}
if (key == IdOccurrenceUser) {
return ssOccurrenceUser;
}
if (key == IdOccurrenceRoleName) {
return ssOccurrenceRoleName;
}
if (key == IdAccessIP) {
return ssAccessIP;
}
if (key == IdIsError) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssOrigin;
}
if (attributeKey == IdIdentifier.Key.AsGuid) {
return ssIdentifier;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdScreen.Key.AsGuid) {
return ssScreen;
}
if (attributeKey == IdFunctionality.Key.AsGuid) {
return ssFunctionality;
}
if (attributeKey == IdOriginalJSON.Key.AsGuid) {
return ssOriginalJSON;
}
if (attributeKey == IdChangeJSON.Key.AsGuid) {
return ssChangeJSON;
}
if (attributeKey == IdOccurrenceDateTime.Key.AsGuid) {
return ssOccurrenceDateTime;
}
if (attributeKey == IdOccurrenceUser.Key.AsGuid) {
return ssOccurrenceUser;
}
if (attributeKey == IdOccurrenceRoleName.Key.AsGuid) {
return ssOccurrenceRoleName;
}
if (attributeKey == IdAccessIP.Key.AsGuid) {
return ssAccessIP;
}
if (attributeKey == IdIsError.Key.AsGuid) {
return ssIsError;
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
ssOrigin = (int) other.AttributeGet(IdOrigin);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrigin);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrigin);
ssIdentifier = (long) other.AttributeGet(IdIdentifier);
ChangedAttributes[2] = other.ChangedAttributeGet(IdIdentifier);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdIdentifier);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMessage);
ssScreen = (string) other.AttributeGet(IdScreen);
ChangedAttributes[4] = other.ChangedAttributeGet(IdScreen);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdScreen);
ssFunctionality = (string) other.AttributeGet(IdFunctionality);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFunctionality);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFunctionality);
ssOriginalJSON = (string) other.AttributeGet(IdOriginalJSON);
ChangedAttributes[6] = other.ChangedAttributeGet(IdOriginalJSON);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdOriginalJSON);
ssChangeJSON = (string) other.AttributeGet(IdChangeJSON);
ChangedAttributes[7] = other.ChangedAttributeGet(IdChangeJSON);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdChangeJSON);
ssOccurrenceDateTime = (DateTime) other.AttributeGet(IdOccurrenceDateTime);
ChangedAttributes[8] = other.ChangedAttributeGet(IdOccurrenceDateTime);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdOccurrenceDateTime);
ssOccurrenceUser = (string) other.AttributeGet(IdOccurrenceUser);
ChangedAttributes[9] = other.ChangedAttributeGet(IdOccurrenceUser);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdOccurrenceUser);
ssOccurrenceRoleName = (string) other.AttributeGet(IdOccurrenceRoleName);
ChangedAttributes[10] = other.ChangedAttributeGet(IdOccurrenceRoleName);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdOccurrenceRoleName);
ssAccessIP = (string) other.AttributeGet(IdAccessIP);
ChangedAttributes[11] = other.ChangedAttributeGet(IdAccessIP);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdAccessIP);
ssIsError = (bool) other.AttributeGet(IdIsError);
ChangedAttributes[12] = other.ChangedAttributeGet(IdIsError);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdIsError);
}
} // EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord

/// <summary>
/// RecordList type <code>AuditList</code> that represents a record list of <code>Audit</code>
/// </summary>
public partial class RL_9d970cac6f2e80ca3584b94784f400b4 : GenericRecordList<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord>, IEnumerable, IEnumerator {

protected override EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord GetElementDefaultValue() {
return new EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord();
}

public T[] ToArray<T>(Func<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9d970cac6f2e80ca3584b94784f400b4 recordList, Func<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9d970cac6f2e80ca3584b94784f400b4(EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord[] array) {
  RL_9d970cac6f2e80ca3584b94784f400b4 result = new RL_9d970cac6f2e80ca3584b94784f400b4();
result.InnerFromArray(array);
    return result;
}

public static RL_9d970cac6f2e80ca3584b94784f400b4 ToList<T>(T[] array, Func <T, EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> converter) {
  RL_9d970cac6f2e80ca3584b94784f400b4 result = new RL_9d970cac6f2e80ca3584b94784f400b4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9d970cac6f2e80ca3584b94784f400b4 FromRestList<T>(RestList<T> restList, Func <T, EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> converter) {
  RL_9d970cac6f2e80ca3584b94784f400b4 result = new RL_9d970cac6f2e80ca3584b94784f400b4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9d970cac6f2e80ca3584b94784f400b4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_fdc6adeb06d4944308e866b4240fd4efEntityRecord> NewList() {
return new RL_9d970cac6f2e80ca3584b94784f400b4();
}


} // RL_9d970cac6f2e80ca3584b94784f400b4
}
