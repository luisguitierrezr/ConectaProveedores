using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderApproval (gPB1SctJQUmEhibydqUZag)
///  <code>EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord</code> that represent
/// s <code>OrderApproval</code> <p>Description: </p>
/// </summary>
// Name: OrderApproval
public partial struct EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord : ITypedRecord<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KfAuaUABY02V_M57lMczIQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8JeOvk6AaEWABJKzjAtcxA");
internal static readonly GlobalObjectKey IdCurrentLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O4V+EPDHmkOEIHOOtfPQUw");
internal static readonly GlobalObjectKey IdMaxLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ace96qAnAkeFTAL6wAeG6Q");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aJfcUAmBSEurG_GkZq2BXw");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uEvKrOSKfU+ZIIRy8dnHsg");
internal static readonly GlobalObjectKey IdLastApproverPuestodelGerente = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*z6wi1R_fr0Oxb6KVzDHCsQ");
internal static readonly GlobalObjectKey IdLastApproverPuestodelJefe = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9z3kvA39IkCsuLwt+aRvbw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderId = value;
      }
  }
}

private int _ssCurrentLevel;
public int ssCurrentLevel{
  get{
      return _ssCurrentLevel;
  }
  set{
      if((_ssCurrentLevel!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCurrentLevel = value;
      }
  }
}

private int _ssMaxLevel;
public int ssMaxLevel{
  get{
      return _ssMaxLevel;
  }
  set{
      if((_ssMaxLevel!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMaxLevel = value;
      }
  }
}

private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssStartedOn = value;
      }
  }
}

private DateTime _ssFinishedOn;
public DateTime ssFinishedOn{
  get{
      return _ssFinishedOn;
  }
  set{
      if((_ssFinishedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFinishedOn = value;
      }
  }
}

private string _ssLastApproverPuestodelGerente;
public string ssLastApproverPuestodelGerente{
  get{
      return _ssLastApproverPuestodelGerente;
  }
  set{
      if((_ssLastApproverPuestodelGerente!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssLastApproverPuestodelGerente = value;
      }
  }
}

private string _ssLastApproverPuestodelJefe;
public string ssLastApproverPuestodelJefe{
  get{
      return _ssLastApproverPuestodelJefe;
  }
  set{
      if((_ssLastApproverPuestodelJefe!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssLastApproverPuestodelJefe = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssOrderId = 0L;
_ssCurrentLevel = 0;
_ssMaxLevel = 0;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFinishedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLastApproverPuestodelGerente = "";
_ssLastApproverPuestodelJefe = "";
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
ssId = r.ReadLongInteger(index++, "OrderApproval.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderApproval.OrderId", 0L);
ssCurrentLevel = r.ReadInteger(index++, "OrderApproval.CurrentLevel", 0);
ssMaxLevel = r.ReadInteger(index++, "OrderApproval.MaxLevel", 0);
ssStartedOn = r.ReadDateTime(index++, "OrderApproval.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "OrderApproval.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLastApproverPuestodelGerente = r.ReadText(index++, "OrderApproval.LastApproverPuestodelGerente", "");
ssLastApproverPuestodelJefe = r.ReadText(index++, "OrderApproval.LastApproverPuestodelJefe", "");
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord r) {
this = r;
}


public static bool operator == (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord a, EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssCurrentLevel != b.ssCurrentLevel) return false;
if (a.ssMaxLevel != b.ssMaxLevel) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
if (a.ssLastApproverPuestodelGerente != b.ssLastApproverPuestodelGerente) return false;
if (a.ssLastApproverPuestodelJefe != b.ssLastApproverPuestodelJefe) return false;
return true;
}

public static bool operator != (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord a, EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)) return false;
return (this == (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssCurrentLevel.GetHashCode()
 ^ ssMaxLevel.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssFinishedOn.GetHashCode()
 ^ ssLastApproverPuestodelGerente.GetHashCode()
 ^ ssLastApproverPuestodelJefe.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord Duplicate() {
EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
t._ssCurrentLevel = this._ssCurrentLevel;
t._ssMaxLevel = this._ssMaxLevel;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
t._ssLastApproverPuestodelGerente = this._ssLastApproverPuestodelGerente;
t._ssLastApproverPuestodelJefe = this._ssLastApproverPuestodelJefe;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "currentlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentLevel")) variable.Value = ssCurrentLevel; else variable.Optimized = true;
} else if (head == "maxlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxLevel")) variable.Value = ssMaxLevel; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "finishedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishedOn")) variable.Value = ssFinishedOn; else variable.Optimized = true;
} else if (head == "lastapproverpuestodelgerente") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApproverPuestodelGerente")) variable.Value = ssLastApproverPuestodelGerente; else variable.Optimized = true;
} else if (head == "lastapproverpuestodeljefe") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApproverPuestodelJefe")) variable.Value = ssLastApproverPuestodelJefe; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCurrentLevel)) {
return ChangedAttributes[2];
}
if (key.Equals(IdMaxLevel)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdLastApproverPuestodelGerente)) {
return ChangedAttributes[6];
}
if (key.Equals(IdLastApproverPuestodelJefe)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCurrentLevel)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdMaxLevel)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdLastApproverPuestodelGerente)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdLastApproverPuestodelJefe)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderId) {
return ssOrderId;
}
if (key == IdCurrentLevel) {
return ssCurrentLevel;
}
if (key == IdMaxLevel) {
return ssMaxLevel;
}
if (key == IdStartedOn) {
return ssStartedOn;
}
if (key == IdFinishedOn) {
return ssFinishedOn;
}
if (key == IdLastApproverPuestodelGerente) {
return ssLastApproverPuestodelGerente;
}
if (key == IdLastApproverPuestodelJefe) {
return ssLastApproverPuestodelJefe;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
if (attributeKey == IdCurrentLevel.Key.AsGuid) {
return ssCurrentLevel;
}
if (attributeKey == IdMaxLevel.Key.AsGuid) {
return ssMaxLevel;
}
if (attributeKey == IdStartedOn.Key.AsGuid) {
return ssStartedOn;
}
if (attributeKey == IdFinishedOn.Key.AsGuid) {
return ssFinishedOn;
}
if (attributeKey == IdLastApproverPuestodelGerente.Key.AsGuid) {
return ssLastApproverPuestodelGerente;
}
if (attributeKey == IdLastApproverPuestodelJefe.Key.AsGuid) {
return ssLastApproverPuestodelJefe;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
ssCurrentLevel = (int) other.AttributeGet(IdCurrentLevel);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCurrentLevel);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCurrentLevel);
ssMaxLevel = (int) other.AttributeGet(IdMaxLevel);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMaxLevel);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMaxLevel);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFinishedOn);
ssLastApproverPuestodelGerente = (string) other.AttributeGet(IdLastApproverPuestodelGerente);
ChangedAttributes[6] = other.ChangedAttributeGet(IdLastApproverPuestodelGerente);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdLastApproverPuestodelGerente);
ssLastApproverPuestodelJefe = (string) other.AttributeGet(IdLastApproverPuestodelJefe);
ChangedAttributes[7] = other.ChangedAttributeGet(IdLastApproverPuestodelJefe);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdLastApproverPuestodelJefe);
}
} // EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord

/// <summary>
/// RecordList type <code>OrderApprovalList</code> that represents a record list of
///  <code>OrderApproval</code>
/// </summary>
public partial class RL_f2ecd54ad77f2306db9cc295b5d3f95f : GenericRecordList<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord>, IEnumerable, IEnumerator {

protected override EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord GetElementDefaultValue() {
return new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
}

public T[] ToArray<T>(Func<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2ecd54ad77f2306db9cc295b5d3f95f recordList, Func<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2ecd54ad77f2306db9cc295b5d3f95f(EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord[] array) {
  RL_f2ecd54ad77f2306db9cc295b5d3f95f result = new RL_f2ecd54ad77f2306db9cc295b5d3f95f();
result.InnerFromArray(array);
    return result;
}

public static RL_f2ecd54ad77f2306db9cc295b5d3f95f ToList<T>(T[] array, Func <T, EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> converter) {
  RL_f2ecd54ad77f2306db9cc295b5d3f95f result = new RL_f2ecd54ad77f2306db9cc295b5d3f95f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2ecd54ad77f2306db9cc295b5d3f95f FromRestList<T>(RestList<T> restList, Func <T, EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> converter) {
  RL_f2ecd54ad77f2306db9cc295b5d3f95f result = new RL_f2ecd54ad77f2306db9cc295b5d3f95f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2ecd54ad77f2306db9cc295b5d3f95f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> NewList() {
return new RL_f2ecd54ad77f2306db9cc295b5d3f95f();
}


} // RL_f2ecd54ad77f2306db9cc295b5d3f95f
}
