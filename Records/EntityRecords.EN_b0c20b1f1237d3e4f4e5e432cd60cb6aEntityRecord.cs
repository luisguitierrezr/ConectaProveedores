using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedReceiver (anV8ZLmoOEGPGpmWLLdweA)
///  <code>EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord</code> that represent
/// s <code>InvoiceExtendedReceiver</code> <p>Description: Entity that holds Invoice Extended
///  Receiver.</p>
/// </summary>
// Name: InvoiceExtendedReceiver
public partial struct EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord : ITypedRecord<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tU9q0BFMm0a_y1pOfYWoDA");
internal static readonly GlobalObjectKey IdRFC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZD4kNIIDEE+0Q6q2fupeeA");
internal static readonly GlobalObjectKey IdNombre = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pkWBjAC8y0OChxisiXeOTA");
internal static readonly GlobalObjectKey IdRegimenFiscal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+Qw0HxheBE6nH38exqXO1w");
internal static readonly GlobalObjectKey IdCodigoPostal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NMdQ3_KCfUqMLpEosRcGUw");

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

private string _ssRFC;
public string ssRFC{
  get{
      return _ssRFC;
  }
  set{
      if((_ssRFC!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRFC = value;
      }
  }
}

private string _ssNombre;
public string ssNombre{
  get{
      return _ssNombre;
  }
  set{
      if((_ssNombre!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssNombre = value;
      }
  }
}

private string _ssRegimenFiscal;
public string ssRegimenFiscal{
  get{
      return _ssRegimenFiscal;
  }
  set{
      if((_ssRegimenFiscal!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRegimenFiscal = value;
      }
  }
}

private string _ssCodigoPostal;
public string ssCodigoPostal{
  get{
      return _ssCodigoPostal;
  }
  set{
      if((_ssCodigoPostal!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCodigoPostal = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssRFC = "";
_ssNombre = "";
_ssRegimenFiscal = "";
_ssCodigoPostal = "";
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
ssId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedReceiver.Id", 0L);
ssRFC = r.ReadText(index++, "InvoiceExtendedReceiver.RFC", "");
ssNombre = r.ReadText(index++, "InvoiceExtendedReceiver.Nombre", "");
ssRegimenFiscal = r.ReadText(index++, "InvoiceExtendedReceiver.RegimenFiscal", "");
ssCodigoPostal = r.ReadText(index++, "InvoiceExtendedReceiver.CodigoPostal", "");
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
public void ReadIM(EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord r) {
this = r;
}


public static bool operator == (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord a, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRFC != b.ssRFC) return false;
if (a.ssNombre != b.ssNombre) return false;
if (a.ssRegimenFiscal != b.ssRegimenFiscal) return false;
if (a.ssCodigoPostal != b.ssCodigoPostal) return false;
return true;
}

public static bool operator != (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord a, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord)) return false;
return (this == (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRFC.GetHashCode()
 ^ ssNombre.GetHashCode()
 ^ ssRegimenFiscal.GetHashCode()
 ^ ssCodigoPostal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord Duplicate() {
EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord t;
t._ssId = this._ssId;
t._ssRFC = this._ssRFC;
t._ssNombre = this._ssNombre;
t._ssRegimenFiscal = this._ssRegimenFiscal;
t._ssCodigoPostal = this._ssCodigoPostal;
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
} else if (head == "rfc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RFC")) variable.Value = ssRFC; else variable.Optimized = true;
} else if (head == "nombre") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre")) variable.Value = ssNombre; else variable.Optimized = true;
} else if (head == "regimenfiscal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegimenFiscal")) variable.Value = ssRegimenFiscal; else variable.Optimized = true;
} else if (head == "codigopostal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CodigoPostal")) variable.Value = ssCodigoPostal; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRFC)) {
return ChangedAttributes[1];
}
if (key.Equals(IdNombre)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRegimenFiscal)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCodigoPostal)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRFC)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdNombre)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRegimenFiscal)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCodigoPostal)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRFC) {
return ssRFC;
}
if (key == IdNombre) {
return ssNombre;
}
if (key == IdRegimenFiscal) {
return ssRegimenFiscal;
}
if (key == IdCodigoPostal) {
return ssCodigoPostal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRFC.Key.AsGuid) {
return ssRFC;
}
if (attributeKey == IdNombre.Key.AsGuid) {
return ssNombre;
}
if (attributeKey == IdRegimenFiscal.Key.AsGuid) {
return ssRegimenFiscal;
}
if (attributeKey == IdCodigoPostal.Key.AsGuid) {
return ssCodigoPostal;
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
ssRFC = (string) other.AttributeGet(IdRFC);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRFC);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRFC);
ssNombre = (string) other.AttributeGet(IdNombre);
ChangedAttributes[2] = other.ChangedAttributeGet(IdNombre);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdNombre);
ssRegimenFiscal = (string) other.AttributeGet(IdRegimenFiscal);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRegimenFiscal);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRegimenFiscal);
ssCodigoPostal = (string) other.AttributeGet(IdCodigoPostal);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCodigoPostal);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCodigoPostal);
}
} // EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedReceiverList</code> that represents a record list of
///  <code>InvoiceExtendedReceiver</code>
/// </summary>
public partial class RL_0d9d1c226afa78d63268efd2c1bcd358 : GenericRecordList<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord GetElementDefaultValue() {
return new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();
}

public T[] ToArray<T>(Func<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0d9d1c226afa78d63268efd2c1bcd358 recordList, Func<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0d9d1c226afa78d63268efd2c1bcd358(EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord[] array) {
  RL_0d9d1c226afa78d63268efd2c1bcd358 result = new RL_0d9d1c226afa78d63268efd2c1bcd358();
result.InnerFromArray(array);
    return result;
}

public static RL_0d9d1c226afa78d63268efd2c1bcd358 ToList<T>(T[] array, Func <T, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> converter) {
  RL_0d9d1c226afa78d63268efd2c1bcd358 result = new RL_0d9d1c226afa78d63268efd2c1bcd358();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0d9d1c226afa78d63268efd2c1bcd358 FromRestList<T>(RestList<T> restList, Func <T, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> converter) {
  RL_0d9d1c226afa78d63268efd2c1bcd358 result = new RL_0d9d1c226afa78d63268efd2c1bcd358();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0d9d1c226afa78d63268efd2c1bcd358() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> NewList() {
return new RL_0d9d1c226afa78d63268efd2c1bcd358();
}


} // RL_0d9d1c226afa78d63268efd2c1bcd358
}
