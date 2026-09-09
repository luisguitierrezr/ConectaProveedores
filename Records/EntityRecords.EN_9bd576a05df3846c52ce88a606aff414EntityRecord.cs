using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedCartaPorte (mmtRc6LV00Kwg0c_1WzrNg)
///  <code>EN_9bd576a05df3846c52ce88a606aff414EntityRecord</code> that represent
/// s <code>InvoiceExtendedCartaPorte</code> <p>Description: Entity that holds Invoice Extended Carta
///  Porte.</p>
/// </summary>
// Name: InvoiceExtendedCartaPorte
public partial struct EN_9bd576a05df3846c52ce88a606aff414EntityRecord : ITypedRecord<EN_9bd576a05df3846c52ce88a606aff414EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DX4DUerSHU655byraSl6LQ");
internal static readonly GlobalObjectKey IdDescripcion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yvt6KfDXM0qPpyb24oz29g");
internal static readonly GlobalObjectKey IdValorMercancia = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Aml1oo6NxUqXdtuJYgTnXQ");
internal static readonly GlobalObjectKey IdCentroAtencion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SMSIsIHomE+FVKBx2S3sWQ");
internal static readonly GlobalObjectKey IdCalle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*75PIDB6b30K4h4Llrtp2Vg");
internal static readonly GlobalObjectKey IdNumeroExterior = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pU61cV9lEUCdOrOPcKoysQ");
internal static readonly GlobalObjectKey IdCodigoPostal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pO1huT+YKECZ6lrQTtivEg");

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

private string _ssDescripcion;
public string ssDescripcion{
  get{
      return _ssDescripcion;
  }
  set{
      if((_ssDescripcion!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssDescripcion = value;
      }
  }
}

private decimal _ssValorMercancia;
public decimal ssValorMercancia{
  get{
      return _ssValorMercancia;
  }
  set{
      if((_ssValorMercancia!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssValorMercancia = value;
      }
  }
}

private string _ssCentroAtencion;
public string ssCentroAtencion{
  get{
      return _ssCentroAtencion;
  }
  set{
      if((_ssCentroAtencion!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCentroAtencion = value;
      }
  }
}

private string _ssCalle;
public string ssCalle{
  get{
      return _ssCalle;
  }
  set{
      if((_ssCalle!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCalle = value;
      }
  }
}

private string _ssNumeroExterior;
public string ssNumeroExterior{
  get{
      return _ssNumeroExterior;
  }
  set{
      if((_ssNumeroExterior!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssNumeroExterior = value;
      }
  }
}

private string _ssCodigoPostal;
public string ssCodigoPostal{
  get{
      return _ssCodigoPostal;
  }
  set{
      if((_ssCodigoPostal!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCodigoPostal = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9bd576a05df3846c52ce88a606aff414EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssDescripcion = "";
_ssValorMercancia = 0.0M;
_ssCentroAtencion = "";
_ssCalle = "";
_ssNumeroExterior = "";
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
ssId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedCartaPorte.Id", 0L);
ssDescripcion = r.ReadText(index++, "InvoiceExtendedCartaPorte.Descripcion", "");
ssValorMercancia = r.ReadDecimal(index++, "InvoiceExtendedCartaPorte.ValorMercancia", 0.0M);
ssCentroAtencion = r.ReadText(index++, "InvoiceExtendedCartaPorte.CentroAtencion", "");
ssCalle = r.ReadText(index++, "InvoiceExtendedCartaPorte.Calle", "");
ssNumeroExterior = r.ReadText(index++, "InvoiceExtendedCartaPorte.NumeroExterior", "");
ssCodigoPostal = r.ReadText(index++, "InvoiceExtendedCartaPorte.CodigoPostal", "");
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
public void ReadIM(EN_9bd576a05df3846c52ce88a606aff414EntityRecord r) {
this = r;
}


public static bool operator == (EN_9bd576a05df3846c52ce88a606aff414EntityRecord a, EN_9bd576a05df3846c52ce88a606aff414EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescripcion != b.ssDescripcion) return false;
if (a.ssValorMercancia != b.ssValorMercancia) return false;
if (a.ssCentroAtencion != b.ssCentroAtencion) return false;
if (a.ssCalle != b.ssCalle) return false;
if (a.ssNumeroExterior != b.ssNumeroExterior) return false;
if (a.ssCodigoPostal != b.ssCodigoPostal) return false;
return true;
}

public static bool operator != (EN_9bd576a05df3846c52ce88a606aff414EntityRecord a, EN_9bd576a05df3846c52ce88a606aff414EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9bd576a05df3846c52ce88a606aff414EntityRecord)) return false;
return (this == (EN_9bd576a05df3846c52ce88a606aff414EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescripcion.GetHashCode()
 ^ ssValorMercancia.GetHashCode()
 ^ ssCentroAtencion.GetHashCode()
 ^ ssCalle.GetHashCode()
 ^ ssNumeroExterior.GetHashCode()
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


public EN_9bd576a05df3846c52ce88a606aff414EntityRecord Duplicate() {
EN_9bd576a05df3846c52ce88a606aff414EntityRecord t;
t._ssId = this._ssId;
t._ssDescripcion = this._ssDescripcion;
t._ssValorMercancia = this._ssValorMercancia;
t._ssCentroAtencion = this._ssCentroAtencion;
t._ssCalle = this._ssCalle;
t._ssNumeroExterior = this._ssNumeroExterior;
t._ssCodigoPostal = this._ssCodigoPostal;
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
} else if (head == "descripcion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Descripcion")) variable.Value = ssDescripcion; else variable.Optimized = true;
} else if (head == "valormercancia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValorMercancia")) variable.Value = ssValorMercancia; else variable.Optimized = true;
} else if (head == "centroatencion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CentroAtencion")) variable.Value = ssCentroAtencion; else variable.Optimized = true;
} else if (head == "calle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Calle")) variable.Value = ssCalle; else variable.Optimized = true;
} else if (head == "numeroexterior") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumeroExterior")) variable.Value = ssNumeroExterior; else variable.Optimized = true;
} else if (head == "codigopostal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CodigoPostal")) variable.Value = ssCodigoPostal; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdDescripcion)) {
return ChangedAttributes[1];
}
if (key.Equals(IdValorMercancia)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCentroAtencion)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCalle)) {
return ChangedAttributes[4];
}
if (key.Equals(IdNumeroExterior)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCodigoPostal)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdDescripcion)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdValorMercancia)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCentroAtencion)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCalle)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdNumeroExterior)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCodigoPostal)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdDescripcion) {
return ssDescripcion;
}
if (key == IdValorMercancia) {
return ssValorMercancia;
}
if (key == IdCentroAtencion) {
return ssCentroAtencion;
}
if (key == IdCalle) {
return ssCalle;
}
if (key == IdNumeroExterior) {
return ssNumeroExterior;
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
if (attributeKey == IdDescripcion.Key.AsGuid) {
return ssDescripcion;
}
if (attributeKey == IdValorMercancia.Key.AsGuid) {
return ssValorMercancia;
}
if (attributeKey == IdCentroAtencion.Key.AsGuid) {
return ssCentroAtencion;
}
if (attributeKey == IdCalle.Key.AsGuid) {
return ssCalle;
}
if (attributeKey == IdNumeroExterior.Key.AsGuid) {
return ssNumeroExterior;
}
if (attributeKey == IdCodigoPostal.Key.AsGuid) {
return ssCodigoPostal;
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
ssDescripcion = (string) other.AttributeGet(IdDescripcion);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescripcion);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescripcion);
ssValorMercancia = (decimal) other.AttributeGet(IdValorMercancia);
ChangedAttributes[2] = other.ChangedAttributeGet(IdValorMercancia);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdValorMercancia);
ssCentroAtencion = (string) other.AttributeGet(IdCentroAtencion);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCentroAtencion);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCentroAtencion);
ssCalle = (string) other.AttributeGet(IdCalle);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCalle);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCalle);
ssNumeroExterior = (string) other.AttributeGet(IdNumeroExterior);
ChangedAttributes[5] = other.ChangedAttributeGet(IdNumeroExterior);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdNumeroExterior);
ssCodigoPostal = (string) other.AttributeGet(IdCodigoPostal);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCodigoPostal);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCodigoPostal);
}
} // EN_9bd576a05df3846c52ce88a606aff414EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedCartaPorteList</code> that represents a record list of
///  <code>InvoiceExtendedCartaPorte</code>
/// </summary>
public partial class RL_ed6076e58e15f9ba3fafddc3ba64173c : GenericRecordList<EN_9bd576a05df3846c52ce88a606aff414EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9bd576a05df3846c52ce88a606aff414EntityRecord GetElementDefaultValue() {
return new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();
}

public T[] ToArray<T>(Func<EN_9bd576a05df3846c52ce88a606aff414EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ed6076e58e15f9ba3fafddc3ba64173c recordList, Func<EN_9bd576a05df3846c52ce88a606aff414EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ed6076e58e15f9ba3fafddc3ba64173c(EN_9bd576a05df3846c52ce88a606aff414EntityRecord[] array) {
  RL_ed6076e58e15f9ba3fafddc3ba64173c result = new RL_ed6076e58e15f9ba3fafddc3ba64173c();
result.InnerFromArray(array);
    return result;
}

public static RL_ed6076e58e15f9ba3fafddc3ba64173c ToList<T>(T[] array, Func <T, EN_9bd576a05df3846c52ce88a606aff414EntityRecord> converter) {
  RL_ed6076e58e15f9ba3fafddc3ba64173c result = new RL_ed6076e58e15f9ba3fafddc3ba64173c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ed6076e58e15f9ba3fafddc3ba64173c FromRestList<T>(RestList<T> restList, Func <T, EN_9bd576a05df3846c52ce88a606aff414EntityRecord> converter) {
  RL_ed6076e58e15f9ba3fafddc3ba64173c result = new RL_ed6076e58e15f9ba3fafddc3ba64173c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ed6076e58e15f9ba3fafddc3ba64173c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9bd576a05df3846c52ce88a606aff414EntityRecord> NewList() {
return new RL_ed6076e58e15f9ba3fafddc3ba64173c();
}


} // RL_ed6076e58e15f9ba3fafddc3ba64173c
}
