using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoicePoliza (Frpm05lJZEiL6zGSgcTR1Q)
///  <code>EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord</code> that represent
/// s <code>InvoicePoliza</code> <p>Description: Poliza Flow</p>
/// </summary>
// Name: InvoicePoliza
public partial struct EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord : ITypedRecord<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7hmxltCF50Sg9FDdErpNyA");
internal static readonly GlobalObjectKey IdPolizaId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VLeKKMf0hkSl5aA6MvYrpQ");
internal static readonly GlobalObjectKey IdPolizaSAP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yXbhdU2dEE2nxcN2LrkbpA");
internal static readonly GlobalObjectKey IdSAPObject = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bO+xBxR4NkCWVYdvfKdr4Q");
internal static readonly GlobalObjectKey IdSent = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nhRXlthyukqohgbFQZUOng");
internal static readonly GlobalObjectKey IdSentWhen = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xHgq+RI1UkOJNDynDPLv6g");
internal static readonly GlobalObjectKey IdWithError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6CamAcZ7UUmylKn_KMf98Q");
internal static readonly GlobalObjectKey IdError_Message = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*k68+wvkjx0ertarPQlgaTQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bb789W9FAUGbBFbfYWknpQ");

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

private string _ssPolizaId;
public string ssPolizaId{
  get{
      return _ssPolizaId;
  }
  set{
      if((_ssPolizaId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssPolizaId = value;
      }
  }
}

private string _ssPolizaSAP;
public string ssPolizaSAP{
  get{
      return _ssPolizaSAP;
  }
  set{
      if((_ssPolizaSAP!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssPolizaSAP = value;
      }
  }
}

private string _ssSAPObject;
public string ssSAPObject{
  get{
      return _ssSAPObject;
  }
  set{
      if((_ssSAPObject!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssSAPObject = value;
      }
  }
}

private bool _ssSent;
public bool ssSent{
  get{
      return _ssSent;
  }
  set{
      if((_ssSent!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssSent = value;
      }
  }
}

private DateTime _ssSentWhen;
public DateTime ssSentWhen{
  get{
      return _ssSentWhen;
  }
  set{
      if((_ssSentWhen!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssSentWhen = value;
      }
  }
}

private bool _ssWithError;
public bool ssWithError{
  get{
      return _ssWithError;
  }
  set{
      if((_ssWithError!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssWithError = value;
      }
  }
}

private string _ssError_Message;
public string ssError_Message{
  get{
      return _ssError_Message;
  }
  set{
      if((_ssError_Message!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssError_Message = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssPolizaId = "";
_ssPolizaSAP = "";
_ssSAPObject = "";
_ssSent = false;
_ssSentWhen = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssWithError = false;
_ssError_Message = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadEntityReferenceLongInteger(index++, "InvoicePoliza.Id", 0L);
ssPolizaId = r.ReadText(index++, "InvoicePoliza.PolizaId", "");
ssPolizaSAP = r.ReadText(index++, "InvoicePoliza.PolizaSAP", "");
ssSAPObject = r.ReadText(index++, "InvoicePoliza.SAPObject", "");
ssSent = r.ReadBoolean(index++, "InvoicePoliza.Sent", false);
ssSentWhen = r.ReadDateTime(index++, "InvoicePoliza.SentWhen", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssWithError = r.ReadBoolean(index++, "InvoicePoliza.WithError", false);
ssError_Message = r.ReadText(index++, "InvoicePoliza.Error_Message", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoicePoliza.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord r) {
this = r;
}


public static bool operator == (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord a, EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssPolizaId != b.ssPolizaId) return false;
if (a.ssPolizaSAP != b.ssPolizaSAP) return false;
if (a.ssSAPObject != b.ssSAPObject) return false;
if (a.ssSent != b.ssSent) return false;
if (a.ssSentWhen != b.ssSentWhen) return false;
if (a.ssWithError != b.ssWithError) return false;
if (a.ssError_Message != b.ssError_Message) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord a, EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)) return false;
return (this == (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssPolizaId.GetHashCode()
 ^ ssPolizaSAP.GetHashCode()
 ^ ssSAPObject.GetHashCode()
 ^ ssSent.GetHashCode()
 ^ ssSentWhen.GetHashCode()
 ^ ssWithError.GetHashCode()
 ^ ssError_Message.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord Duplicate() {
EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord t;
t._ssId = this._ssId;
t._ssPolizaId = this._ssPolizaId;
t._ssPolizaSAP = this._ssPolizaSAP;
t._ssSAPObject = this._ssSAPObject;
t._ssSent = this._ssSent;
t._ssSentWhen = this._ssSentWhen;
t._ssWithError = this._ssWithError;
t._ssError_Message = this._ssError_Message;
t._ssCreatedOn = this._ssCreatedOn;
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
} else if (head == "polizaid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PolizaId")) variable.Value = ssPolizaId; else variable.Optimized = true;
} else if (head == "polizasap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PolizaSAP")) variable.Value = ssPolizaSAP; else variable.Optimized = true;
} else if (head == "sapobject") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SAPObject")) variable.Value = ssSAPObject; else variable.Optimized = true;
} else if (head == "sent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sent")) variable.Value = ssSent; else variable.Optimized = true;
} else if (head == "sentwhen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SentWhen")) variable.Value = ssSentWhen; else variable.Optimized = true;
} else if (head == "witherror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WithError")) variable.Value = ssWithError; else variable.Optimized = true;
} else if (head == "error_message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Error_Message")) variable.Value = ssError_Message; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdPolizaId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdPolizaSAP)) {
return ChangedAttributes[2];
}
if (key.Equals(IdSAPObject)) {
return ChangedAttributes[3];
}
if (key.Equals(IdSent)) {
return ChangedAttributes[4];
}
if (key.Equals(IdSentWhen)) {
return ChangedAttributes[5];
}
if (key.Equals(IdWithError)) {
return ChangedAttributes[6];
}
if (key.Equals(IdError_Message)) {
return ChangedAttributes[7];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[8];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdPolizaId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdPolizaSAP)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdSAPObject)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdSent)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdSentWhen)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdWithError)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdError_Message)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[8];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdPolizaId) {
return ssPolizaId;
}
if (key == IdPolizaSAP) {
return ssPolizaSAP;
}
if (key == IdSAPObject) {
return ssSAPObject;
}
if (key == IdSent) {
return ssSent;
}
if (key == IdSentWhen) {
return ssSentWhen;
}
if (key == IdWithError) {
return ssWithError;
}
if (key == IdError_Message) {
return ssError_Message;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdPolizaId.Key.AsGuid) {
return ssPolizaId;
}
if (attributeKey == IdPolizaSAP.Key.AsGuid) {
return ssPolizaSAP;
}
if (attributeKey == IdSAPObject.Key.AsGuid) {
return ssSAPObject;
}
if (attributeKey == IdSent.Key.AsGuid) {
return ssSent;
}
if (attributeKey == IdSentWhen.Key.AsGuid) {
return ssSentWhen;
}
if (attributeKey == IdWithError.Key.AsGuid) {
return ssWithError;
}
if (attributeKey == IdError_Message.Key.AsGuid) {
return ssError_Message;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
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
ssPolizaId = (string) other.AttributeGet(IdPolizaId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdPolizaId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdPolizaId);
ssPolizaSAP = (string) other.AttributeGet(IdPolizaSAP);
ChangedAttributes[2] = other.ChangedAttributeGet(IdPolizaSAP);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdPolizaSAP);
ssSAPObject = (string) other.AttributeGet(IdSAPObject);
ChangedAttributes[3] = other.ChangedAttributeGet(IdSAPObject);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdSAPObject);
ssSent = (bool) other.AttributeGet(IdSent);
ChangedAttributes[4] = other.ChangedAttributeGet(IdSent);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdSent);
ssSentWhen = (DateTime) other.AttributeGet(IdSentWhen);
ChangedAttributes[5] = other.ChangedAttributeGet(IdSentWhen);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdSentWhen);
ssWithError = (bool) other.AttributeGet(IdWithError);
ChangedAttributes[6] = other.ChangedAttributeGet(IdWithError);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdWithError);
ssError_Message = (string) other.AttributeGet(IdError_Message);
ChangedAttributes[7] = other.ChangedAttributeGet(IdError_Message);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdError_Message);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord

/// <summary>
/// RecordList type <code>InvoicePolizaList</code> that represents a record list of
///  <code>InvoicePoliza</code>
/// </summary>
public partial class RL_522df3e84b32223cbe061a0a74cada79 : GenericRecordList<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord>, IEnumerable, IEnumerator {

protected override EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord GetElementDefaultValue() {
return new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
}

public T[] ToArray<T>(Func<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_522df3e84b32223cbe061a0a74cada79 recordList, Func<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_522df3e84b32223cbe061a0a74cada79(EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord[] array) {
  RL_522df3e84b32223cbe061a0a74cada79 result = new RL_522df3e84b32223cbe061a0a74cada79();
result.InnerFromArray(array);
    return result;
}

public static RL_522df3e84b32223cbe061a0a74cada79 ToList<T>(T[] array, Func <T, EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> converter) {
  RL_522df3e84b32223cbe061a0a74cada79 result = new RL_522df3e84b32223cbe061a0a74cada79();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_522df3e84b32223cbe061a0a74cada79 FromRestList<T>(RestList<T> restList, Func <T, EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> converter) {
  RL_522df3e84b32223cbe061a0a74cada79 result = new RL_522df3e84b32223cbe061a0a74cada79();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_522df3e84b32223cbe061a0a74cada79() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> NewList() {
return new RL_522df3e84b32223cbe061a0a74cada79();
}


} // RL_522df3e84b32223cbe061a0a74cada79
}
