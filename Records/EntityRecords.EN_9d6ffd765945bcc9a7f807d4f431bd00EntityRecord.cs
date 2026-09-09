using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Supplier (_PhDRnpo_UqfBF+0tANfmA)
///  <code>EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord</code> that represents <code>Supplier</code
/// > <p>Description: Entity holds the Suppliers. (In spanish Proveedores).</p>
/// </summary>
// Name: Supplier
public partial struct EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord : ITypedRecord<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*W+5d3Ki3WEy6396INaE+XQ");
internal static readonly GlobalObjectKey IdTratamiento = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*o+3fSe3pP0+_0SPuHdWj6g");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*sVXRvSMQKk+1Xc3DN6Yj4w");
internal static readonly GlobalObjectKey IdNumber = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2J2WHTG75kmGy_7eVewqyA");
internal static readonly GlobalObjectKey IdConceptobusq_1_2 = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*miGKEg_lCUaUGCn4jBLQrQ");
internal static readonly GlobalObjectKey IdCalle_Numero = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*AJq8n+p7RUyFxf4QyEDnLg");
internal static readonly GlobalObjectKey IdDistrito = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*OJyf8+_ZeES3CN7ohc64sA");
internal static readonly GlobalObjectKey IdCodigopostal_Pobl_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cpuok19tl0SVDMyiDOLk2w");
internal static readonly GlobalObjectKey IdPais = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*jo4+Rk9a+UySZ9_yhLZEJA");
internal static readonly GlobalObjectKey IdRegion_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*h6MR4ak5fEisNflyQm6tSw");
internal static readonly GlobalObjectKey IdIdioma = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*g4ssq2Xf90OgGJ1ysud5Pw");
internal static readonly GlobalObjectKey IdTelefono = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ohq4l8eqmU2Ps827Gy4ZBg");
internal static readonly GlobalObjectKey IdExtension = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Br1azuYXakWiiuj31iAfNA");
internal static readonly GlobalObjectKey IdFax = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*85zChLQzr0arfFG6BFAZmw");
internal static readonly GlobalObjectKey IdCliente = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*I0eiARgk_UiP7h91_UOJQg");
internal static readonly GlobalObjectKey IdSoc_GLasociada = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*OKee0bj39EaxC6zA+SV2dA");
internal static readonly GlobalObjectKey IdClavedegrupo = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*f9KlC99UnECF6cF59onM_Q");
internal static readonly GlobalObjectKey IdN_ident_fis_1 = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*wIBqC0fjBEmLcNYF54iN2Q");
internal static readonly GlobalObjectKey IdPersonafisica = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*D7aZOi5qykm1QrhpSRdnyw");
internal static readonly GlobalObjectKey IdRamo = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0HPidjjG0UqcLArLm+q72g");
internal static readonly GlobalObjectKey IdGrupodeporte = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*TcLL3iuBJk+oA3Bz1sIeHg");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*AZYb3MSyaka_osO3Fu5GCw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VZuvxbNpVkeIPoigzOB2uQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YiciuF0PHU62YA5NxhrQxQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*6Qp5yM4b50252e5CrmroGA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*4ibzV4ex1ESvmyOo9yB99w");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*u4OvpeCqMkGlGcfnWc5EPw");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+qPDGpGALkyRFn3yF4nqmA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(28,true);
          _ssId = value;
      }
  }
}

private string _ssTratamiento;
public string ssTratamiento{
  get{
      return _ssTratamiento;
  }
  set{
      if((_ssTratamiento!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssTratamiento = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssName = value;
      }
  }
}

private string _ssNumber;
public string ssNumber{
  get{
      return _ssNumber;
  }
  set{
      if((_ssNumber!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssNumber = value;
      }
  }
}

private string _ssConceptobusq_1_2;
public string ssConceptobusq_1_2{
  get{
      return _ssConceptobusq_1_2;
  }
  set{
      if((_ssConceptobusq_1_2!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssConceptobusq_1_2 = value;
      }
  }
}

private string _ssCalle_Numero;
public string ssCalle_Numero{
  get{
      return _ssCalle_Numero;
  }
  set{
      if((_ssCalle_Numero!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCalle_Numero = value;
      }
  }
}

private string _ssDistrito;
public string ssDistrito{
  get{
      return _ssDistrito;
  }
  set{
      if((_ssDistrito!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDistrito = value;
      }
  }
}

private string _ssCodigopostal_Pobl_;
public string ssCodigopostal_Pobl_{
  get{
      return _ssCodigopostal_Pobl_;
  }
  set{
      if((_ssCodigopostal_Pobl_!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCodigopostal_Pobl_ = value;
      }
  }
}

private string _ssPais;
public string ssPais{
  get{
      return _ssPais;
  }
  set{
      if((_ssPais!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssPais = value;
      }
  }
}

private string _ssRegion_;
public string ssRegion_{
  get{
      return _ssRegion_;
  }
  set{
      if((_ssRegion_!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssRegion_ = value;
      }
  }
}

private string _ssIdioma;
public string ssIdioma{
  get{
      return _ssIdioma;
  }
  set{
      if((_ssIdioma!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssIdioma = value;
      }
  }
}

private string _ssTelefono;
public string ssTelefono{
  get{
      return _ssTelefono;
  }
  set{
      if((_ssTelefono!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssTelefono = value;
      }
  }
}

private string _ssExtension;
public string ssExtension{
  get{
      return _ssExtension;
  }
  set{
      if((_ssExtension!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssExtension = value;
      }
  }
}

private string _ssFax;
public string ssFax{
  get{
      return _ssFax;
  }
  set{
      if((_ssFax!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssFax = value;
      }
  }
}

private string _ssCliente;
public string ssCliente{
  get{
      return _ssCliente;
  }
  set{
      if((_ssCliente!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCliente = value;
      }
  }
}

private string _ssSoc_GLasociada;
public string ssSoc_GLasociada{
  get{
      return _ssSoc_GLasociada;
  }
  set{
      if((_ssSoc_GLasociada!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssSoc_GLasociada = value;
      }
  }
}

private string _ssClavedegrupo;
public string ssClavedegrupo{
  get{
      return _ssClavedegrupo;
  }
  set{
      if((_ssClavedegrupo!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssClavedegrupo = value;
      }
  }
}

private string _ssN_ident_fis_1;
public string ssN_ident_fis_1{
  get{
      return _ssN_ident_fis_1;
  }
  set{
      if((_ssN_ident_fis_1!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssN_ident_fis_1 = value;
      }
  }
}

private string _ssPersonafisica;
public string ssPersonafisica{
  get{
      return _ssPersonafisica;
  }
  set{
      if((_ssPersonafisica!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssPersonafisica = value;
      }
  }
}

private string _ssRamo;
public string ssRamo{
  get{
      return _ssRamo;
  }
  set{
      if((_ssRamo!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssRamo = value;
      }
  }
}

private string _ssGrupodeporte;
public string ssGrupodeporte{
  get{
      return _ssGrupodeporte;
  }
  set{
      if((_ssGrupodeporte!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssGrupodeporte = value;
      }
  }
}

private string _ssEmail;
public string ssEmail{
  get{
      return _ssEmail;
  }
  set{
      if((_ssEmail!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssEmail = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssIsActive = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssUpdatedBy = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssRegionId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord() {
ChangedAttributes = new BitArray(28,true);
OptimizedAttributes = new BitArray(28,false);
_ssId = 0L;
_ssTratamiento = "";
_ssName = "";
_ssNumber = "";
_ssConceptobusq_1_2 = "";
_ssCalle_Numero = "";
_ssDistrito = "";
_ssCodigopostal_Pobl_ = "";
_ssPais = "";
_ssRegion_ = "";
_ssIdioma = "";
_ssTelefono = "";
_ssExtension = "";
_ssFax = "";
_ssCliente = "";
_ssSoc_GLasociada = "";
_ssClavedegrupo = "";
_ssN_ident_fis_1 = "";
_ssPersonafisica = "";
_ssRamo = "";
_ssGrupodeporte = "";
_ssEmail = "";
_ssIsActive = true;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssRegionId = 0L;
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
ssId = r.ReadLongInteger(index++, "Supplier.Id", 0L);
ssTratamiento = r.ReadText(index++, "Supplier.Tratamiento", "");
ssName = r.ReadText(index++, "Supplier.Name", "");
ssNumber = r.ReadText(index++, "Supplier.Number", "");
ssConceptobusq_1_2 = r.ReadText(index++, "Supplier.Conceptobusq_1_2", "");
ssCalle_Numero = r.ReadText(index++, "Supplier.Calle_Numero", "");
ssDistrito = r.ReadText(index++, "Supplier.Distrito", "");
ssCodigopostal_Pobl_ = r.ReadText(index++, "Supplier.Codigopostal_Pobl_", "");
ssPais = r.ReadText(index++, "Supplier.Pais", "");
ssRegion_ = r.ReadText(index++, "Supplier.Region_", "");
ssIdioma = r.ReadText(index++, "Supplier.Idioma", "");
ssTelefono = r.ReadText(index++, "Supplier.Telefono", "");
ssExtension = r.ReadText(index++, "Supplier.Extension", "");
ssFax = r.ReadText(index++, "Supplier.Fax", "");
ssCliente = r.ReadText(index++, "Supplier.Cliente", "");
ssSoc_GLasociada = r.ReadText(index++, "Supplier.Soc_GLasociada", "");
ssClavedegrupo = r.ReadText(index++, "Supplier.Clavedegrupo", "");
ssN_ident_fis_1 = r.ReadText(index++, "Supplier.N_ident_fis_1", "");
ssPersonafisica = r.ReadText(index++, "Supplier.Personafisica", "");
ssRamo = r.ReadText(index++, "Supplier.Ramo", "");
ssGrupodeporte = r.ReadText(index++, "Supplier.Grupodeporte", "");
ssEmail = r.ReadEmail(index++, "Supplier.Email", "");
ssIsActive = r.ReadBoolean(index++, "Supplier.IsActive", true);
ssCreatedOn = r.ReadDateTime(index++, "Supplier.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Supplier.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Supplier.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Supplier.UpdatedBy", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "Supplier.RegionId", 0L);
ChangedAttributes = new BitArray(28,false);
OptimizedAttributes = new BitArray(28,false);
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
public void ReadIM(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord r) {
this = r;
}


public static bool operator == (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord a, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssTratamiento != b.ssTratamiento) return false;
if (a.ssName != b.ssName) return false;
if (a.ssNumber != b.ssNumber) return false;
if (a.ssConceptobusq_1_2 != b.ssConceptobusq_1_2) return false;
if (a.ssCalle_Numero != b.ssCalle_Numero) return false;
if (a.ssDistrito != b.ssDistrito) return false;
if (a.ssCodigopostal_Pobl_ != b.ssCodigopostal_Pobl_) return false;
if (a.ssPais != b.ssPais) return false;
if (a.ssRegion_ != b.ssRegion_) return false;
if (a.ssIdioma != b.ssIdioma) return false;
if (a.ssTelefono != b.ssTelefono) return false;
if (a.ssExtension != b.ssExtension) return false;
if (a.ssFax != b.ssFax) return false;
if (a.ssCliente != b.ssCliente) return false;
if (a.ssSoc_GLasociada != b.ssSoc_GLasociada) return false;
if (a.ssClavedegrupo != b.ssClavedegrupo) return false;
if (a.ssN_ident_fis_1 != b.ssN_ident_fis_1) return false;
if (a.ssPersonafisica != b.ssPersonafisica) return false;
if (a.ssRamo != b.ssRamo) return false;
if (a.ssGrupodeporte != b.ssGrupodeporte) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord a, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)) return false;
return (this == (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssTratamiento.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssNumber.GetHashCode()
 ^ ssConceptobusq_1_2.GetHashCode()
 ^ ssCalle_Numero.GetHashCode()
 ^ ssDistrito.GetHashCode()
 ^ ssCodigopostal_Pobl_.GetHashCode()
 ^ ssPais.GetHashCode()
 ^ ssRegion_.GetHashCode()
 ^ ssIdioma.GetHashCode()
 ^ ssTelefono.GetHashCode()
 ^ ssExtension.GetHashCode()
 ^ ssFax.GetHashCode()
 ^ ssCliente.GetHashCode()
 ^ ssSoc_GLasociada.GetHashCode()
 ^ ssClavedegrupo.GetHashCode()
 ^ ssN_ident_fis_1.GetHashCode()
 ^ ssPersonafisica.GetHashCode()
 ^ ssRamo.GetHashCode()
 ^ ssGrupodeporte.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord Duplicate() {
EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord t;
t._ssId = this._ssId;
t._ssTratamiento = this._ssTratamiento;
t._ssName = this._ssName;
t._ssNumber = this._ssNumber;
t._ssConceptobusq_1_2 = this._ssConceptobusq_1_2;
t._ssCalle_Numero = this._ssCalle_Numero;
t._ssDistrito = this._ssDistrito;
t._ssCodigopostal_Pobl_ = this._ssCodigopostal_Pobl_;
t._ssPais = this._ssPais;
t._ssRegion_ = this._ssRegion_;
t._ssIdioma = this._ssIdioma;
t._ssTelefono = this._ssTelefono;
t._ssExtension = this._ssExtension;
t._ssFax = this._ssFax;
t._ssCliente = this._ssCliente;
t._ssSoc_GLasociada = this._ssSoc_GLasociada;
t._ssClavedegrupo = this._ssClavedegrupo;
t._ssN_ident_fis_1 = this._ssN_ident_fis_1;
t._ssPersonafisica = this._ssPersonafisica;
t._ssRamo = this._ssRamo;
t._ssGrupodeporte = this._ssGrupodeporte;
t._ssEmail = this._ssEmail;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssRegionId = this._ssRegionId;
t.ChangedAttributes = new BitArray(28);
t.OptimizedAttributes = new BitArray(28);
for(int i = 0; i < 28; i++){
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
} else if (head == "tratamiento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tratamiento")) variable.Value = ssTratamiento; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "number") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Number")) variable.Value = ssNumber; else variable.Optimized = true;
} else if (head == "conceptobusq_1_2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Conceptobusq_1_2")) variable.Value = ssConceptobusq_1_2; else variable.Optimized = true;
} else if (head == "calle_numero") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Calle_Numero")) variable.Value = ssCalle_Numero; else variable.Optimized = true;
} else if (head == "distrito") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distrito")) variable.Value = ssDistrito; else variable.Optimized = true;
} else if (head == "codigopostal_pobl_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Codigopostal_Pobl_")) variable.Value = ssCodigopostal_Pobl_; else variable.Optimized = true;
} else if (head == "pais") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Pais")) variable.Value = ssPais; else variable.Optimized = true;
} else if (head == "region_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region_")) variable.Value = ssRegion_; else variable.Optimized = true;
} else if (head == "idioma") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Idioma")) variable.Value = ssIdioma; else variable.Optimized = true;
} else if (head == "telefono") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Telefono")) variable.Value = ssTelefono; else variable.Optimized = true;
} else if (head == "extension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Extension")) variable.Value = ssExtension; else variable.Optimized = true;
} else if (head == "fax") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fax")) variable.Value = ssFax; else variable.Optimized = true;
} else if (head == "cliente") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cliente")) variable.Value = ssCliente; else variable.Optimized = true;
} else if (head == "soc_glasociada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Soc_GLasociada")) variable.Value = ssSoc_GLasociada; else variable.Optimized = true;
} else if (head == "clavedegrupo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Clavedegrupo")) variable.Value = ssClavedegrupo; else variable.Optimized = true;
} else if (head == "n_ident_fis_1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".N_ident_fis_1")) variable.Value = ssN_ident_fis_1; else variable.Optimized = true;
} else if (head == "personafisica") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Personafisica")) variable.Value = ssPersonafisica; else variable.Optimized = true;
} else if (head == "ramo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ramo")) variable.Value = ssRamo; else variable.Optimized = true;
} else if (head == "grupodeporte") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Grupodeporte")) variable.Value = ssGrupodeporte; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdTratamiento)) {
return ChangedAttributes[1];
}
if (key.Equals(IdName)) {
return ChangedAttributes[2];
}
if (key.Equals(IdNumber)) {
return ChangedAttributes[3];
}
if (key.Equals(IdConceptobusq_1_2)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCalle_Numero)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDistrito)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCodigopostal_Pobl_)) {
return ChangedAttributes[7];
}
if (key.Equals(IdPais)) {
return ChangedAttributes[8];
}
if (key.Equals(IdRegion_)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIdioma)) {
return ChangedAttributes[10];
}
if (key.Equals(IdTelefono)) {
return ChangedAttributes[11];
}
if (key.Equals(IdExtension)) {
return ChangedAttributes[12];
}
if (key.Equals(IdFax)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCliente)) {
return ChangedAttributes[14];
}
if (key.Equals(IdSoc_GLasociada)) {
return ChangedAttributes[15];
}
if (key.Equals(IdClavedegrupo)) {
return ChangedAttributes[16];
}
if (key.Equals(IdN_ident_fis_1)) {
return ChangedAttributes[17];
}
if (key.Equals(IdPersonafisica)) {
return ChangedAttributes[18];
}
if (key.Equals(IdRamo)) {
return ChangedAttributes[19];
}
if (key.Equals(IdGrupodeporte)) {
return ChangedAttributes[20];
}
if (key.Equals(IdEmail)) {
return ChangedAttributes[21];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[22];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[23];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[24];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[25];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[26];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[27];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdTratamiento)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdNumber)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdConceptobusq_1_2)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCalle_Numero)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDistrito)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCodigopostal_Pobl_)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdPais)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdRegion_)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIdioma)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdTelefono)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdExtension)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdFax)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCliente)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdSoc_GLasociada)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdClavedegrupo)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdN_ident_fis_1)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdPersonafisica)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdRamo)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdGrupodeporte)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdEmail)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[27];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdTratamiento) {
return ssTratamiento;
}
if (key == IdName) {
return ssName;
}
if (key == IdNumber) {
return ssNumber;
}
if (key == IdConceptobusq_1_2) {
return ssConceptobusq_1_2;
}
if (key == IdCalle_Numero) {
return ssCalle_Numero;
}
if (key == IdDistrito) {
return ssDistrito;
}
if (key == IdCodigopostal_Pobl_) {
return ssCodigopostal_Pobl_;
}
if (key == IdPais) {
return ssPais;
}
if (key == IdRegion_) {
return ssRegion_;
}
if (key == IdIdioma) {
return ssIdioma;
}
if (key == IdTelefono) {
return ssTelefono;
}
if (key == IdExtension) {
return ssExtension;
}
if (key == IdFax) {
return ssFax;
}
if (key == IdCliente) {
return ssCliente;
}
if (key == IdSoc_GLasociada) {
return ssSoc_GLasociada;
}
if (key == IdClavedegrupo) {
return ssClavedegrupo;
}
if (key == IdN_ident_fis_1) {
return ssN_ident_fis_1;
}
if (key == IdPersonafisica) {
return ssPersonafisica;
}
if (key == IdRamo) {
return ssRamo;
}
if (key == IdGrupodeporte) {
return ssGrupodeporte;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdIsActive) {
return ssIsActive;
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
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdTratamiento.Key.AsGuid) {
return ssTratamiento;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdNumber.Key.AsGuid) {
return ssNumber;
}
if (attributeKey == IdConceptobusq_1_2.Key.AsGuid) {
return ssConceptobusq_1_2;
}
if (attributeKey == IdCalle_Numero.Key.AsGuid) {
return ssCalle_Numero;
}
if (attributeKey == IdDistrito.Key.AsGuid) {
return ssDistrito;
}
if (attributeKey == IdCodigopostal_Pobl_.Key.AsGuid) {
return ssCodigopostal_Pobl_;
}
if (attributeKey == IdPais.Key.AsGuid) {
return ssPais;
}
if (attributeKey == IdRegion_.Key.AsGuid) {
return ssRegion_;
}
if (attributeKey == IdIdioma.Key.AsGuid) {
return ssIdioma;
}
if (attributeKey == IdTelefono.Key.AsGuid) {
return ssTelefono;
}
if (attributeKey == IdExtension.Key.AsGuid) {
return ssExtension;
}
if (attributeKey == IdFax.Key.AsGuid) {
return ssFax;
}
if (attributeKey == IdCliente.Key.AsGuid) {
return ssCliente;
}
if (attributeKey == IdSoc_GLasociada.Key.AsGuid) {
return ssSoc_GLasociada;
}
if (attributeKey == IdClavedegrupo.Key.AsGuid) {
return ssClavedegrupo;
}
if (attributeKey == IdN_ident_fis_1.Key.AsGuid) {
return ssN_ident_fis_1;
}
if (attributeKey == IdPersonafisica.Key.AsGuid) {
return ssPersonafisica;
}
if (attributeKey == IdRamo.Key.AsGuid) {
return ssRamo;
}
if (attributeKey == IdGrupodeporte.Key.AsGuid) {
return ssGrupodeporte;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
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
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(28);
OptimizedAttributes = new BitArray(28);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssTratamiento = (string) other.AttributeGet(IdTratamiento);
ChangedAttributes[1] = other.ChangedAttributeGet(IdTratamiento);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTratamiento);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
ssNumber = (string) other.AttributeGet(IdNumber);
ChangedAttributes[3] = other.ChangedAttributeGet(IdNumber);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdNumber);
ssConceptobusq_1_2 = (string) other.AttributeGet(IdConceptobusq_1_2);
ChangedAttributes[4] = other.ChangedAttributeGet(IdConceptobusq_1_2);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdConceptobusq_1_2);
ssCalle_Numero = (string) other.AttributeGet(IdCalle_Numero);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCalle_Numero);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCalle_Numero);
ssDistrito = (string) other.AttributeGet(IdDistrito);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDistrito);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDistrito);
ssCodigopostal_Pobl_ = (string) other.AttributeGet(IdCodigopostal_Pobl_);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCodigopostal_Pobl_);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCodigopostal_Pobl_);
ssPais = (string) other.AttributeGet(IdPais);
ChangedAttributes[8] = other.ChangedAttributeGet(IdPais);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdPais);
ssRegion_ = (string) other.AttributeGet(IdRegion_);
ChangedAttributes[9] = other.ChangedAttributeGet(IdRegion_);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdRegion_);
ssIdioma = (string) other.AttributeGet(IdIdioma);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIdioma);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIdioma);
ssTelefono = (string) other.AttributeGet(IdTelefono);
ChangedAttributes[11] = other.ChangedAttributeGet(IdTelefono);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdTelefono);
ssExtension = (string) other.AttributeGet(IdExtension);
ChangedAttributes[12] = other.ChangedAttributeGet(IdExtension);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdExtension);
ssFax = (string) other.AttributeGet(IdFax);
ChangedAttributes[13] = other.ChangedAttributeGet(IdFax);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdFax);
ssCliente = (string) other.AttributeGet(IdCliente);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCliente);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCliente);
ssSoc_GLasociada = (string) other.AttributeGet(IdSoc_GLasociada);
ChangedAttributes[15] = other.ChangedAttributeGet(IdSoc_GLasociada);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdSoc_GLasociada);
ssClavedegrupo = (string) other.AttributeGet(IdClavedegrupo);
ChangedAttributes[16] = other.ChangedAttributeGet(IdClavedegrupo);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdClavedegrupo);
ssN_ident_fis_1 = (string) other.AttributeGet(IdN_ident_fis_1);
ChangedAttributes[17] = other.ChangedAttributeGet(IdN_ident_fis_1);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdN_ident_fis_1);
ssPersonafisica = (string) other.AttributeGet(IdPersonafisica);
ChangedAttributes[18] = other.ChangedAttributeGet(IdPersonafisica);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdPersonafisica);
ssRamo = (string) other.AttributeGet(IdRamo);
ChangedAttributes[19] = other.ChangedAttributeGet(IdRamo);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdRamo);
ssGrupodeporte = (string) other.AttributeGet(IdGrupodeporte);
ChangedAttributes[20] = other.ChangedAttributeGet(IdGrupodeporte);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdGrupodeporte);
ssEmail = (string) other.AttributeGet(IdEmail);
ChangedAttributes[21] = other.ChangedAttributeGet(IdEmail);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdEmail);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[22] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[23] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[24] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[25] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[26] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdUpdatedBy);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[27] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdRegionId);
}
} // EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord

/// <summary>
/// RecordList type <code>SupplierList</code> that represents a record list of <code>Supplier</code>
/// </summary>
public partial class RL_bc4f56473df5efe07325fa275b2b52ef : GenericRecordList<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord GetElementDefaultValue() {
return new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public T[] ToArray<T>(Func<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bc4f56473df5efe07325fa275b2b52ef recordList, Func<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bc4f56473df5efe07325fa275b2b52ef(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord[] array) {
  RL_bc4f56473df5efe07325fa275b2b52ef result = new RL_bc4f56473df5efe07325fa275b2b52ef();
result.InnerFromArray(array);
    return result;
}

public static RL_bc4f56473df5efe07325fa275b2b52ef ToList<T>(T[] array, Func <T, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> converter) {
  RL_bc4f56473df5efe07325fa275b2b52ef result = new RL_bc4f56473df5efe07325fa275b2b52ef();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bc4f56473df5efe07325fa275b2b52ef FromRestList<T>(RestList<T> restList, Func <T, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> converter) {
  RL_bc4f56473df5efe07325fa275b2b52ef result = new RL_bc4f56473df5efe07325fa275b2b52ef();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bc4f56473df5efe07325fa275b2b52ef() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord> NewList() {
return new RL_bc4f56473df5efe07325fa275b2b52ef();
}


} // RL_bc4f56473df5efe07325fa275b2b52ef
}
