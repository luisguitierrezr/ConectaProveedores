using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioSAPData (YS0WA4NT0Eu8JEHGf6YJyQ)
///  <code>EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord</code> that represent
/// s <code>FolioSAPData</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPData
public partial struct EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord : ITypedRecord<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sdDHNUpu00eUQX401rz9Wg");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kQNBri7prkeJ6JB2lvfEOw");
internal static readonly GlobalObjectKey IdService = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IkmBNq9aaUa6_BZ7aU3X0g");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_EM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TdJXYJrTWkaFSVM+b8hIfg");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_SM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NynsalyK9kWXEQHpkCvWvQ");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_221 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FS_osGAthkuMUx+EMpKcfw");
internal static readonly GlobalObjectKey IdPO_DOCUMENTO_MATERIAL_415 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rcuo3w7n+UGwk9L49RuV3A");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_EM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bEJskNgV2kmNR_5Mzn4ACQ");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_SM = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wceoH11mBkqQpzQMgndQ+A");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_221 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ShxVxPbrP0GqrVQZYojr+w");
internal static readonly GlobalObjectKey IdPO_EJERCICIO_415 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*G9DkD9loN0m+oIhxVGww5w");
internal static readonly GlobalObjectKey IdPO_FOLIO_AGRUPADOS = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+4fOnnFB5UmMp8NlgOWybg");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WxJJ12UL1EyBBU6s0Q4wyA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wavGCwB6hEiOQWPZTyICvA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2h59dCOfZUOOqta2bdzOIw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(15,true);
          _ssId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioId = value;
      }
  }
}

private string _ssService;
public string ssService{
  get{
      return _ssService;
  }
  set{
      if((_ssService!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssService = value;
      }
  }
}

private string _ssPO_DOCUMENTO_MATERIAL_EM;
public string ssPO_DOCUMENTO_MATERIAL_EM{
  get{
      return _ssPO_DOCUMENTO_MATERIAL_EM;
  }
  set{
      if((_ssPO_DOCUMENTO_MATERIAL_EM!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssPO_DOCUMENTO_MATERIAL_EM = value;
      }
  }
}

private string _ssPO_DOCUMENTO_MATERIAL_SM;
public string ssPO_DOCUMENTO_MATERIAL_SM{
  get{
      return _ssPO_DOCUMENTO_MATERIAL_SM;
  }
  set{
      if((_ssPO_DOCUMENTO_MATERIAL_SM!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPO_DOCUMENTO_MATERIAL_SM = value;
      }
  }
}

private string _ssPO_DOCUMENTO_MATERIAL_221;
public string ssPO_DOCUMENTO_MATERIAL_221{
  get{
      return _ssPO_DOCUMENTO_MATERIAL_221;
  }
  set{
      if((_ssPO_DOCUMENTO_MATERIAL_221!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssPO_DOCUMENTO_MATERIAL_221 = value;
      }
  }
}

private string _ssPO_DOCUMENTO_MATERIAL_415;
public string ssPO_DOCUMENTO_MATERIAL_415{
  get{
      return _ssPO_DOCUMENTO_MATERIAL_415;
  }
  set{
      if((_ssPO_DOCUMENTO_MATERIAL_415!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssPO_DOCUMENTO_MATERIAL_415 = value;
      }
  }
}

private string _ssPO_EJERCICIO_EM;
public string ssPO_EJERCICIO_EM{
  get{
      return _ssPO_EJERCICIO_EM;
  }
  set{
      if((_ssPO_EJERCICIO_EM!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssPO_EJERCICIO_EM = value;
      }
  }
}

private string _ssPO_EJERCICIO_SM;
public string ssPO_EJERCICIO_SM{
  get{
      return _ssPO_EJERCICIO_SM;
  }
  set{
      if((_ssPO_EJERCICIO_SM!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssPO_EJERCICIO_SM = value;
      }
  }
}

private string _ssPO_EJERCICIO_221;
public string ssPO_EJERCICIO_221{
  get{
      return _ssPO_EJERCICIO_221;
  }
  set{
      if((_ssPO_EJERCICIO_221!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssPO_EJERCICIO_221 = value;
      }
  }
}

private string _ssPO_EJERCICIO_415;
public string ssPO_EJERCICIO_415{
  get{
      return _ssPO_EJERCICIO_415;
  }
  set{
      if((_ssPO_EJERCICIO_415!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssPO_EJERCICIO_415 = value;
      }
  }
}

private string _ssPO_FOLIO_AGRUPADOS;
public string ssPO_FOLIO_AGRUPADOS{
  get{
      return _ssPO_FOLIO_AGRUPADOS;
  }
  set{
      if((_ssPO_FOLIO_AGRUPADOS!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssPO_FOLIO_AGRUPADOS = value;
      }
  }
}

private string _ssPO_RESULTADO;
public string ssPO_RESULTADO{
  get{
      return _ssPO_RESULTADO;
  }
  set{
      if((_ssPO_RESULTADO!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssPO_RESULTADO = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord() {
ChangedAttributes = new BitArray(15,true);
OptimizedAttributes = new BitArray(15,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssService = "";
_ssPO_DOCUMENTO_MATERIAL_EM = "";
_ssPO_DOCUMENTO_MATERIAL_SM = "";
_ssPO_DOCUMENTO_MATERIAL_221 = "";
_ssPO_DOCUMENTO_MATERIAL_415 = "";
_ssPO_EJERCICIO_EM = "";
_ssPO_EJERCICIO_SM = "";
_ssPO_EJERCICIO_221 = "";
_ssPO_EJERCICIO_415 = "";
_ssPO_FOLIO_AGRUPADOS = "";
_ssPO_RESULTADO = "";
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "FolioSAPData.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioSAPData.FolioId", 0L);
ssService = r.ReadText(index++, "FolioSAPData.Service", "");
ssPO_DOCUMENTO_MATERIAL_EM = r.ReadText(index++, "FolioSAPData.PO_DOCUMENTO_MATERIAL_EM", "");
ssPO_DOCUMENTO_MATERIAL_SM = r.ReadText(index++, "FolioSAPData.PO_DOCUMENTO_MATERIAL_SM", "");
ssPO_DOCUMENTO_MATERIAL_221 = r.ReadText(index++, "FolioSAPData.PO_DOCUMENTO_MATERIAL_221", "");
ssPO_DOCUMENTO_MATERIAL_415 = r.ReadText(index++, "FolioSAPData.PO_DOCUMENTO_MATERIAL_415", "");
ssPO_EJERCICIO_EM = r.ReadText(index++, "FolioSAPData.PO_EJERCICIO_EM", "");
ssPO_EJERCICIO_SM = r.ReadText(index++, "FolioSAPData.PO_EJERCICIO_SM", "");
ssPO_EJERCICIO_221 = r.ReadText(index++, "FolioSAPData.PO_EJERCICIO_221", "");
ssPO_EJERCICIO_415 = r.ReadText(index++, "FolioSAPData.PO_EJERCICIO_415", "");
ssPO_FOLIO_AGRUPADOS = r.ReadText(index++, "FolioSAPData.PO_FOLIO_AGRUPADOS", "");
ssPO_RESULTADO = r.ReadText(index++, "FolioSAPData.PO_RESULTADO", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioSAPData.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "FolioSAPData.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(15,false);
OptimizedAttributes = new BitArray(15,false);
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
public void ReadIM(EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord r) {
this = r;
}


public static bool operator == (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord a, EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssService != b.ssService) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_EM != b.ssPO_DOCUMENTO_MATERIAL_EM) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_SM != b.ssPO_DOCUMENTO_MATERIAL_SM) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_221 != b.ssPO_DOCUMENTO_MATERIAL_221) return false;
if (a.ssPO_DOCUMENTO_MATERIAL_415 != b.ssPO_DOCUMENTO_MATERIAL_415) return false;
if (a.ssPO_EJERCICIO_EM != b.ssPO_EJERCICIO_EM) return false;
if (a.ssPO_EJERCICIO_SM != b.ssPO_EJERCICIO_SM) return false;
if (a.ssPO_EJERCICIO_221 != b.ssPO_EJERCICIO_221) return false;
if (a.ssPO_EJERCICIO_415 != b.ssPO_EJERCICIO_415) return false;
if (a.ssPO_FOLIO_AGRUPADOS != b.ssPO_FOLIO_AGRUPADOS) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord a, EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)) return false;
return (this == (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssService.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_EM.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_SM.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_221.GetHashCode()
 ^ ssPO_DOCUMENTO_MATERIAL_415.GetHashCode()
 ^ ssPO_EJERCICIO_EM.GetHashCode()
 ^ ssPO_EJERCICIO_SM.GetHashCode()
 ^ ssPO_EJERCICIO_221.GetHashCode()
 ^ ssPO_EJERCICIO_415.GetHashCode()
 ^ ssPO_FOLIO_AGRUPADOS.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
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


public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord Duplicate() {
EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssService = this._ssService;
t._ssPO_DOCUMENTO_MATERIAL_EM = this._ssPO_DOCUMENTO_MATERIAL_EM;
t._ssPO_DOCUMENTO_MATERIAL_SM = this._ssPO_DOCUMENTO_MATERIAL_SM;
t._ssPO_DOCUMENTO_MATERIAL_221 = this._ssPO_DOCUMENTO_MATERIAL_221;
t._ssPO_DOCUMENTO_MATERIAL_415 = this._ssPO_DOCUMENTO_MATERIAL_415;
t._ssPO_EJERCICIO_EM = this._ssPO_EJERCICIO_EM;
t._ssPO_EJERCICIO_SM = this._ssPO_EJERCICIO_SM;
t._ssPO_EJERCICIO_221 = this._ssPO_EJERCICIO_221;
t._ssPO_EJERCICIO_415 = this._ssPO_EJERCICIO_415;
t._ssPO_FOLIO_AGRUPADOS = this._ssPO_FOLIO_AGRUPADOS;
t._ssPO_RESULTADO = this._ssPO_RESULTADO;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t.ChangedAttributes = new BitArray(15);
t.OptimizedAttributes = new BitArray(15);
for(int i = 0; i < 15; i++){
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
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Service")) variable.Value = ssService; else variable.Optimized = true;
} else if (head == "po_documento_material_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_EM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_EM; else variable.Optimized = true;
} else if (head == "po_documento_material_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_SM")) variable.Value = ssPO_DOCUMENTO_MATERIAL_SM; else variable.Optimized = true;
} else if (head == "po_documento_material_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_221")) variable.Value = ssPO_DOCUMENTO_MATERIAL_221; else variable.Optimized = true;
} else if (head == "po_documento_material_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_DOCUMENTO_MATERIAL_415")) variable.Value = ssPO_DOCUMENTO_MATERIAL_415; else variable.Optimized = true;
} else if (head == "po_ejercicio_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_EM")) variable.Value = ssPO_EJERCICIO_EM; else variable.Optimized = true;
} else if (head == "po_ejercicio_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_SM")) variable.Value = ssPO_EJERCICIO_SM; else variable.Optimized = true;
} else if (head == "po_ejercicio_221") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_221")) variable.Value = ssPO_EJERCICIO_221; else variable.Optimized = true;
} else if (head == "po_ejercicio_415") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_EJERCICIO_415")) variable.Value = ssPO_EJERCICIO_415; else variable.Optimized = true;
} else if (head == "po_folio_agrupados") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_FOLIO_AGRUPADOS")) variable.Value = ssPO_FOLIO_AGRUPADOS; else variable.Optimized = true;
} else if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdService)) {
return ChangedAttributes[2];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_EM)) {
return ChangedAttributes[3];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_SM)) {
return ChangedAttributes[4];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_221)) {
return ChangedAttributes[5];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_415)) {
return ChangedAttributes[6];
}
if (key.Equals(IdPO_EJERCICIO_EM)) {
return ChangedAttributes[7];
}
if (key.Equals(IdPO_EJERCICIO_SM)) {
return ChangedAttributes[8];
}
if (key.Equals(IdPO_EJERCICIO_221)) {
return ChangedAttributes[9];
}
if (key.Equals(IdPO_EJERCICIO_415)) {
return ChangedAttributes[10];
}
if (key.Equals(IdPO_FOLIO_AGRUPADOS)) {
return ChangedAttributes[11];
}
if (key.Equals(IdPO_RESULTADO)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[14];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdService)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_EM)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_SM)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_221)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdPO_DOCUMENTO_MATERIAL_415)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdPO_EJERCICIO_EM)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdPO_EJERCICIO_SM)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdPO_EJERCICIO_221)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdPO_EJERCICIO_415)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdPO_FOLIO_AGRUPADOS)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdPO_RESULTADO)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[14];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdService) {
return ssService;
}
if (key == IdPO_DOCUMENTO_MATERIAL_EM) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (key == IdPO_DOCUMENTO_MATERIAL_SM) {
return ssPO_DOCUMENTO_MATERIAL_SM;
}
if (key == IdPO_DOCUMENTO_MATERIAL_221) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (key == IdPO_DOCUMENTO_MATERIAL_415) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (key == IdPO_EJERCICIO_EM) {
return ssPO_EJERCICIO_EM;
}
if (key == IdPO_EJERCICIO_SM) {
return ssPO_EJERCICIO_SM;
}
if (key == IdPO_EJERCICIO_221) {
return ssPO_EJERCICIO_221;
}
if (key == IdPO_EJERCICIO_415) {
return ssPO_EJERCICIO_415;
}
if (key == IdPO_FOLIO_AGRUPADOS) {
return ssPO_FOLIO_AGRUPADOS;
}
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
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
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdService.Key.AsGuid) {
return ssService;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_EM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_EM;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_SM.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_SM;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_221.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_221;
}
if (attributeKey == IdPO_DOCUMENTO_MATERIAL_415.Key.AsGuid) {
return ssPO_DOCUMENTO_MATERIAL_415;
}
if (attributeKey == IdPO_EJERCICIO_EM.Key.AsGuid) {
return ssPO_EJERCICIO_EM;
}
if (attributeKey == IdPO_EJERCICIO_SM.Key.AsGuid) {
return ssPO_EJERCICIO_SM;
}
if (attributeKey == IdPO_EJERCICIO_221.Key.AsGuid) {
return ssPO_EJERCICIO_221;
}
if (attributeKey == IdPO_EJERCICIO_415.Key.AsGuid) {
return ssPO_EJERCICIO_415;
}
if (attributeKey == IdPO_FOLIO_AGRUPADOS.Key.AsGuid) {
return ssPO_FOLIO_AGRUPADOS;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(15);
OptimizedAttributes = new BitArray(15);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssService = (string) other.AttributeGet(IdService);
ChangedAttributes[2] = other.ChangedAttributeGet(IdService);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdService);
ssPO_DOCUMENTO_MATERIAL_EM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
ChangedAttributes[3] = other.ChangedAttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdPO_DOCUMENTO_MATERIAL_EM);
ssPO_DOCUMENTO_MATERIAL_SM = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_SM);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPO_DOCUMENTO_MATERIAL_SM);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPO_DOCUMENTO_MATERIAL_SM);
ssPO_DOCUMENTO_MATERIAL_221 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_221);
ChangedAttributes[5] = other.ChangedAttributeGet(IdPO_DOCUMENTO_MATERIAL_221);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdPO_DOCUMENTO_MATERIAL_221);
ssPO_DOCUMENTO_MATERIAL_415 = (string) other.AttributeGet(IdPO_DOCUMENTO_MATERIAL_415);
ChangedAttributes[6] = other.ChangedAttributeGet(IdPO_DOCUMENTO_MATERIAL_415);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdPO_DOCUMENTO_MATERIAL_415);
ssPO_EJERCICIO_EM = (string) other.AttributeGet(IdPO_EJERCICIO_EM);
ChangedAttributes[7] = other.ChangedAttributeGet(IdPO_EJERCICIO_EM);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdPO_EJERCICIO_EM);
ssPO_EJERCICIO_SM = (string) other.AttributeGet(IdPO_EJERCICIO_SM);
ChangedAttributes[8] = other.ChangedAttributeGet(IdPO_EJERCICIO_SM);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdPO_EJERCICIO_SM);
ssPO_EJERCICIO_221 = (string) other.AttributeGet(IdPO_EJERCICIO_221);
ChangedAttributes[9] = other.ChangedAttributeGet(IdPO_EJERCICIO_221);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdPO_EJERCICIO_221);
ssPO_EJERCICIO_415 = (string) other.AttributeGet(IdPO_EJERCICIO_415);
ChangedAttributes[10] = other.ChangedAttributeGet(IdPO_EJERCICIO_415);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdPO_EJERCICIO_415);
ssPO_FOLIO_AGRUPADOS = (string) other.AttributeGet(IdPO_FOLIO_AGRUPADOS);
ChangedAttributes[11] = other.ChangedAttributeGet(IdPO_FOLIO_AGRUPADOS);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdPO_FOLIO_AGRUPADOS);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
ChangedAttributes[12] = other.ChangedAttributeGet(IdPO_RESULTADO);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdPO_RESULTADO);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord

/// <summary>
/// RecordList type <code>FolioSAPDataList</code> that represents a record list of
///  <code>FolioSAPData</code>
/// </summary>
public partial class RL_d10879892bf39da06b3316412ab94b18 : GenericRecordList<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord>, IEnumerable, IEnumerator {

protected override EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord GetElementDefaultValue() {
return new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
}

public T[] ToArray<T>(Func<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d10879892bf39da06b3316412ab94b18 recordList, Func<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d10879892bf39da06b3316412ab94b18(EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord[] array) {
  RL_d10879892bf39da06b3316412ab94b18 result = new RL_d10879892bf39da06b3316412ab94b18();
result.InnerFromArray(array);
    return result;
}

public static RL_d10879892bf39da06b3316412ab94b18 ToList<T>(T[] array, Func <T, EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> converter) {
  RL_d10879892bf39da06b3316412ab94b18 result = new RL_d10879892bf39da06b3316412ab94b18();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d10879892bf39da06b3316412ab94b18 FromRestList<T>(RestList<T> restList, Func <T, EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> converter) {
  RL_d10879892bf39da06b3316412ab94b18 result = new RL_d10879892bf39da06b3316412ab94b18();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d10879892bf39da06b3316412ab94b18() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord> NewList() {
return new RL_d10879892bf39da06b3316412ab94b18();
}


} // RL_d10879892bf39da06b3316412ab94b18
}
